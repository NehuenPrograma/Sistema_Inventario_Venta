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

namespace CapaPresentacion.Forms
{
    public partial class FormInventario : Form
    {
        private List<Producto> listaProductos;

        // relacion btnAceptar
        private Producto producto = null;


        public FormInventario()
        {
            InitializeComponent();

            // Actualizar pnlInfoProducto en Modificar segun se cambie el Producto seleccionado
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();
        }

        private void cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos = negocio.Listar();
                dgvInventario.DataSource = listaProductos;
                dgvInventario.Columns["IdProducto"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = true;
            limpiarCamposPanel();
            leerCategoria();
           
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
                Producto seleccionado;
                seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;

                pnlInfoProducto.Visible = true;
                cargarProductoEnPanel(seleccionado);
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
                DialogResult respuesta = MessageBox.Show("Desea eliminar el producto seleccionado, no es reversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgvInventario.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdProducto);
                    cargar();
                }
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
                if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtTalleProducto.Text) && !string.IsNullOrEmpty(txtColorProducto.Text))
                {
                    // Validacion de seleccion Modificar o Agregar
                    if ( producto.IdProducto != 0)
                    {
                        DialogResult respuesta = MessageBox.Show("Esta a punto de modificar un producto", "Modificando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.modificar(producto);
                            MessageBox.Show("Producto modificado", "Modificar producto", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        negocio.agregar(producto);
                        MessageBox.Show("Producto agregado", "Producto Agregado", MessageBoxButtons.OK);
                        limpiarCamposPanel();
                    }

                    cargar();
                    pnlInfoProducto.Visible = false;

                }
                else
                {
                    MessageBox.Show("Los campos Nombre, Talle y Color son obligatorios");
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

    }
}
