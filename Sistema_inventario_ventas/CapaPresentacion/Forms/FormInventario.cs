using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using System.Globalization;
using CapaPresentacion.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormInventario : Form
    {
        private List<Producto> listaProductos;

        // relacion btnAceptar
        private Producto producto = null;

        private Usuario usuarioActual;

        public FormInventario(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;

            // Actualizar pnlInfoProducto en Modificar segun se cambie el Producto seleccionado
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();

            if (usuarioActual.IdRol == 2) 
            {
                desacativarEmpleado();
            }

        }

        private void cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos = negocio.Listar();
                dgvInventario.DataSource = listaProductos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvInventario.Columns["IdProducto"].Visible = false;

        }


        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvInventario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear la columna a la derecha
            dgvInventario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInventario.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInventario.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Ancho automatico
            dgvInventario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columna 8
            dgvInventario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void leerCategoria()
        {
            CD_Categoria categoria = new CD_Categoria();

            try
            {
                cboCategoria.DataSource = categoria.Listar();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBuscarProducto.Text;

            if (filtro != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Talle.ToUpper().Contains(filtro.ToUpper()) || x.Color.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.oCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper())); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaProductos;
            }


            //dgvInventario.DataSource = null;
            dgvInventario.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = true;
            limpiarCamposPanel();
            leerCategoria();
            producto = new Producto();

        }

        private void limpiarCamposPanel()
        {
            // Funcion necesaria para btnAgregarProducto_Click
            cboCategoria.SelectedItem = null;
            txtNombreProducto.Clear();
            txtTalleProducto.Clear();
            txtColorProducto.Clear();
            nudPrecioCompraProducto.Value = 0;
            nudPrecioVentaProducto.Value = 0;
            nudStockProducto.Value = 0;
            txtCodigoProducto.Clear();
            // Limpia los demás campos según sea necesario
        }


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            leerCategoria();

            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.DataBoundItem != null)
            {
                //Producto seleccionado;
                //seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;
                producto = (Producto)dgvInventario.CurrentRow.DataBoundItem;

                pnlInfoProducto.Visible = true;
                cargarProductoEnPanel(producto);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cargarProductoEnPanel(Producto producto)
        {
            // Obtener el producto actual ¡¡¡MUY IMPORTANTE!!!
            this.producto = producto;

            // Funcion necesaria parabtnModificarProducto_Click
            cboCategoria.SelectedValue = producto.oCategoria.IdCategoria;
            txtNombreProducto.Text = producto.Nombre;
            txtTalleProducto.Text = producto.Talle;
            txtColorProducto.Text = producto.Color;

            nudPrecioCompraProducto.Minimum = decimal.MinValue;
            nudPrecioCompraProducto.Maximum = decimal.MaxValue;
            nudPrecioCompraProducto.Value = producto.PrecioCompra;

            nudPrecioVentaProducto.Minimum = decimal.MinValue;
            nudPrecioVentaProducto.Maximum = decimal.MaxValue;
            nudPrecioVentaProducto.Value = producto.PrecioVenta;

            nudStockProducto.Minimum = int.MinValue;
            nudStockProducto.Maximum = int.MaxValue;
            nudStockProducto.Value = producto.Stock;

            txtCodigoProducto.Text = producto.Codigo;
            // Asigna los demás campos según sea necesario
        }


        // Actualizar pnlInfoProducto en Modificar segun se cambie el Producto seleccionado
        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.DataBoundItem != null)
            {
                Producto seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;
                cargarProductoEnPanel(seleccionado);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            CD_Producto negocio = new CD_Producto();
            Producto seleccionado;

            try
            {
                if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.DataBoundItem != null)
                {
                    DialogResult respuesta = MessageBox.Show("Desea eliminar el producto seleccionado, no es reversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.IdProducto);
                        cargar();
                    }
                }
                else
                    MessageBox.Show("Ningun producto selecionado");
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
             
            CD_Producto negocio = new CD_Producto();

            try
            {
                if (producto == null)
                    producto = new Producto();
                
                producto.oCategoria = (Categoria) cboCategoria.SelectedItem;
                producto.Nombre = txtNombreProducto.Text;
                producto.Talle = txtTalleProducto.Text;
                producto.Color = txtColorProducto.Text;
                producto.PrecioCompra = nudPrecioCompraProducto.Value;
                producto.PrecioVenta = nudPrecioVentaProducto.Value;
                producto.Stock = (int)nudStockProducto.Value;
                producto.Codigo = txtCodigoProducto.Text;

                
                // Validacion de campos 
                if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtTalleProducto.Text) && !string.IsNullOrEmpty(txtColorProducto.Text) && !string.IsNullOrEmpty(txtCodigoProducto.Text))
                {
                    // Validacion de seleccion Modificar o Agregar
                    if (producto.IdProducto == 0) // Nuevo producto
                    {
                        if (negocio.productoExiste(producto.Codigo))
                        {
                            MessageBox.Show("El código del producto ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            negocio.agregar(producto);
                            MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposPanel();
                        }
                    }
                    else // Producto existente
                    {
                        negocio.modificar(producto);
                        MessageBox.Show("Producto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cargar();
                    pnlInfoProducto.Visible = false;

                }
                else
                {
                    MessageBox.Show("Los campos Nombre, Talle, Color y Codigo son obligatorios");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
             return true;
        }

        private void btnSumarStockProducto_Click(object sender, EventArgs e) 
        {
            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.DataBoundItem != null)
            {
                Producto seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;

                if(!(string.IsNullOrEmpty(txtSumarStock.Text)))
                {
                    if (soloNumeros(txtSumarStock.Text))
                    {
                        int cantidad = int.Parse(txtSumarStock.Text);

                        CD_Producto negocio = new CD_Producto();
                        negocio.sumarStock(seleccionado.IdProducto, cantidad);
                        if(txtSumarStock.Text != "0")
                        {
                            MessageBox.Show("Stock agregado", "Stock sumado");
                            cargar();
                            txtSumarStock.Text = "0";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Cargar solo numeros por favor", "Solo numeros");
                    }
                }                    

            }
        }

        private void btnRestarStockProducto_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.DataBoundItem != null)
            {
                Producto seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;

                if (!(string.IsNullOrEmpty(txtRestarStock.Text)))
                {
                    if (soloNumeros(txtRestarStock.Text))
                    {
                        int cantidad = int.Parse(txtSumarStock.Text);

                        CD_Producto negocio = new CD_Producto();
                        negocio.sumarStock(seleccionado.IdProducto, cantidad);
                        if (txtRestarStock.Text != "0")
                        {
                            MessageBox.Show("Stock restado", "Stock restado");
                            cargar();
                            txtRestarStock.Text = "0";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cargar solo numeros por favor", "Solo numeros");
                    }
                }
            }
        }


        // Deshabiliatar controles para ROL EMPLEADO  CONTROLAR !!!!

        public void desacativarEmpleado()
        {
            btnAgregarProducto.Visible = false;
            btnModificarProducto.Visible = false;
            btnEliminarProducto.Visible = false;
            btnSumarStockProducto.Visible = false;
            btnRestarStockProducto.Visible = false;
            txtSumarStock.Visible = false;
            txtRestarStock.Visible = false;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            txtAgregarCategoria.Visible = true;
            btnAceptarAgregarCategoria.Visible = true;
        }

        private void btnAceptarAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Descripcion = txtAgregarCategoria.Text;

            CD_Categoria nuevaCategoria = new CD_Categoria();

            try
            {
                nuevaCategoria.agregarCategoria(categoria);
                leerCategoria();
                MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtAgregarCategoria.Visible = false;
            btnAceptarAgregarCategoria.Visible = false;

        }

        private void btnEliminarCategoria__Click(object sender, EventArgs e)  // VALIDAR QUE NO ESTE RELACIONADA CON VENTAS O COMPRAS AL MOMENTO 
            {
            if (cboCategoria.SelectedItem != null)
            {
                Categoria categoriaSeleccionada = (Categoria)cboCategoria.SelectedItem;
                CD_Categoria datosCategoria = new CD_Categoria();

                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar la categoría seleccionada?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        datosCategoria.eliminarCategoria(categoriaSeleccionada.IdCategoria);
                        MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leerCategoria(); // Actualizar lista de categorías
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista.", "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
