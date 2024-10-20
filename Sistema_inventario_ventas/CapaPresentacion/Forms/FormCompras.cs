using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using CapaPresentacion.Modales;

namespace CapaPresentacion.Forms
{
    public partial class FormCompras : Form
    {

        private Form formularioActivo;
        private Usuario usuarioActual;


        public FormCompras(Usuario usuario)
        {

            usuarioActual = usuario;

            InitializeComponent();
            dgvNuevaCompra.CellContentClick += dgvNuevaCompra_CellContentClick;
        }
        private void OpenChildForm(Form formulario)
        {
            if (formularioActivo != null)
            {

                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.BringToFront();
            formulario.Show();
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            OpenChildForm(new FormDetalleVenta());
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            // Agregamos valores al ComboBox
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDoc.DisplayMember = "Texto";
            cboTipoDoc.ValueMember = "Valor";
            cboTipoDoc.SelectedIndex = 0;

            // Obtenemos la fecha actual
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Validar que no se pueda reescribir !!!

            // Definir columnas del DataGridView
            dgvNuevaCompra.Columns.Add("Codigo", "Código");
            dgvNuevaCompra.Columns.Add("Nombre", "Nombre");
            dgvNuevaCompra.Columns.Add("PrecioCompra", "Precio Compra");
            dgvNuevaCompra.Columns.Add("PrecioVenta", "Precio Venta");
            dgvNuevaCompra.Columns.Add("Cantidad", "Cantidad");
            dgvNuevaCompra.Columns.Add("Total", "Total");


            // Añadir columna de botón eliminar con imagen
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = false; // Necesario para usar imagen
            // btnEliminar.Image = Properties.Resources.logo_for_delete_button; // Usa el nombre del recurso !!SOLUCIONAR
            btnEliminar.Text = "Eliminar";
            dgvNuevaCompra.Columns.Add(btnEliminar);

            // Alinear 
            alinearContenidoCeldas();

        }
        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvNuevaCompra.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevaCompra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevaCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevaCompra.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevaCompra.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevaCompra.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear columna a la derecha
            //dgvNuevaCompra.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvNuevaCompra.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvNuevaCompra.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Ancho automatico
            dgvNuevaCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho 8
            dgvNuevaCompra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNuevaCompra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNuevaCompra.Columns[1].Width = 200;
            //dgvNuevaCompra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvNuevaCompra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvNuevaCompra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNuevaCompra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtNumeroDocumento.Text = modal._proveedor.Documento;
                    txtNombreProveedor.Text = modal._proveedor.RazonSocial;
                }
                else
                {
                    txtNumeroDocumento.Select();
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCodigoProducto.Text = modal._producto.Codigo;
                    txtNombreProducto.Text = modal._producto.Nombre + " Talle: " + modal._producto.Talle + " Color: " + modal._producto.Color;
                    txtPrecioCompra.Text = modal._producto.PrecioCompra.ToString("F2");  // Formato decimal con 2 decimales
                    txtPrecioVenta.Text = modal._producto.PrecioVenta.ToString("F2");
                    nudCantidadCompra.Select(); // CONTINUAR DESDE ACA
                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {

                Producto listaProducto = new ProductoNegocio().Listar().Where(x => x.Codigo == txtCodigoProducto.Text).FirstOrDefault();

                if (listaProducto != null)
                {

                    //txtCodigoProducto.
                    txtNombreProducto.Text = listaProducto.Nombre + " Talle: " + listaProducto.Talle + " Color: " + listaProducto.Color;
                    txtPrecioCompra.Text = listaProducto.PrecioCompra.ToString("F2");  // Formato decimal con 2 decimales
                    txtPrecioVenta.Text = listaProducto.PrecioVenta.ToString("F2");
                    nudCantidadCompra.Select(); // CONTINUAR DESDE ACA
                }
                else
                {
                    MessageBox.Show("Código de producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecioCompra.Text = "";
                    txtPrecioVenta.Text = "";
                    txtCodigoProducto.Select();
                }

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                decimal precioCompra = 0;
                decimal precioVenta = 0;
                bool productoExiste = false;
                int cantidad = (int)nudCantidadCompra.Value;

                if (cantidad == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudCantidadCompra.Select();
                    return;
                }
                if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
                {
                    MessageBox.Show("Precio compra - Formato moneda incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioCompra.Select();
                    return;
                }
                if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("Precio venta - Formato moneda incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioVenta.Select();
                    return;
                }

                foreach (DataGridViewRow fila in dgvNuevaCompra.Rows)
                {
                    if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == txtCodigoProducto.Text)
                    {
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {
                    decimal totalPorProducto = precioVenta * cantidad;
                    dgvNuevaCompra.Rows.Add(
                        txtCodigoProducto.Text,
                        txtNombreProducto.Text,
                        txtPrecioCompra.Text,
                        txtPrecioVenta.Text,
                        cantidad,
                        totalPorProducto.ToString("F2") // Total por cantidad en formato "F2"
                    );

                    // Limpiar los campos después de agregar el producto
                    txtCodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecioCompra.Text = "";
                    txtPrecioVenta.Text = "";
                    nudCantidadCompra.Value = 0;
                    txtCodigoProducto.Select();
                }
                else
                {
                    MessageBox.Show("El producto ya existe en la lista de compras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                // Actualizar el total de la compra
                decimal totalCompra = 0;
                foreach (DataGridViewRow fila in dgvNuevaCompra.Rows)
                {
                    if (fila.Cells["Total"].Value != null)
                    {
                        totalCompra += decimal.Parse(fila.Cells["Total"].Value.ToString());
                    }
                }
                txtTotalCompra.Text = totalCompra.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }


        }

        private void dgvNuevaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvNuevaCompra.Columns["btnEliminar"].Index)
                {
                    // Confirmar la eliminación
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Restar el total del producto eliminado del total de la compra
                        if (dgvNuevaCompra.Rows[e.RowIndex].Cells["Total"].Value != null)
                        {
                            decimal totalProducto = decimal.Parse(dgvNuevaCompra.Rows[e.RowIndex].Cells["Total"].Value.ToString());
                            decimal totalCompra = decimal.Parse(txtTotalCompra.Text);
                            totalCompra -= totalProducto;
                            txtTotalCompra.Text = totalCompra.ToString("F2");
                        }

                        // Eliminar la fila
                        dgvNuevaCompra.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el producto: Ningun Producto selecionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
