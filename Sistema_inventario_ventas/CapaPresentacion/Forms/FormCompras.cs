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
using CapaDatos;
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

            // Conectar los eventos con `nudCantidadCompra`
            nudCantidadCompra.Enter += nudCantidadCompra_Enter;
            nudCantidadCompra.KeyPress += nudCantidadCompra_KeyPress;
            nudCantidadCompra.KeyDown += nudCantidadCompra_KeyDown;
        }

        private void nudCantidadCompra_Enter(object sender, EventArgs e)
        {
            if (nudCantidadCompra.Value == 0)
            {
                nudCantidadCompra.Select(0, nudCantidadCompra.Value.ToString().Length); // Selecciona todo el texto para que se reemplace al escribir
            }
        }
        private void nudCantidadCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un dígito o una tecla de control, cancela el evento
            }
        }
        private void nudCantidadCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar_Click(sender, e); // Llama al método btnAgregar_Click al presionar Enter
                e.Handled = true; // Marca el evento como manejado
                e.SuppressKeyPress = true; // Suprime el sonido "ding"
            }
        }

        private void OpenFormInPanel(Form formulario)
        {
            Form activeForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.Name == "Inicio");
            if (activeForm != null)
            {
                Panel pnlDesktop = activeForm.Controls.Find("pnlDesktop", true).FirstOrDefault() as Panel;
                if (pnlDesktop != null)
                {
                    if (formularioActivo != null)
                    {
                        formularioActivo.Close();
                    }
                    formularioActivo = formulario;
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnlDesktop.Controls.Add(formulario);
                    pnlDesktop.Tag = formulario;
                    formulario.BringToFront();
                    formulario.Show();
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormDetalleCompra(usuarioActual));
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
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Definir columnas del DataGridView
            dgvNuevaCompra.Columns.Add("Codigo", "Código");
            dgvNuevaCompra.Columns.Add("Nombre", "Nombre");
            dgvNuevaCompra.Columns.Add("PrecioCompra", "Precio Compra");
            dgvNuevaCompra.Columns.Add("PrecioVenta", "Precio Venta");
            dgvNuevaCompra.Columns.Add("Cantidad", "Cantidad");
            dgvNuevaCompra.Columns.Add("Total", "Total");
            dgvNuevaCompra.Columns.Add("IdProducto", "Id");
            dgvNuevaCompra.Columns["IdProducto"].Visible = false; // Ocultar la columna


            // Añadir columna de botón eliminar con imagen
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = true; // EN FALSE es necesario para usar imagen 
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
        private void limpiarFormulario()
        {
            // Limpiar los campos de texto
            txtNumeroDocumento.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            nudCantidadCompra.Value = 0;
            txtTotalCompra.Text = string.Empty;

            // Limpiar el DataGridView
            dgvNuevaCompra.Rows.Clear();
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

                if (string.IsNullOrEmpty(txtNombreProducto.Text))
                {
                    MessageBox.Show("Debse seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
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
                        totalPorProducto.ToString("F2"), // Total por cantidad en formato "F2"
                        new ProductoNegocio().Listar().FirstOrDefault(p => p.Codigo == txtCodigoProducto.Text)?.IdProducto
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

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombreProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvNuevaCompra.Rows.Count < 1)
            {
                MessageBox.Show("Debse ingresar productos a la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable tabla = new DataTable();

            tabla.Columns.Add("IdProducto", typeof(int));
            tabla.Columns.Add("PrecioCompra", typeof(decimal));
            tabla.Columns.Add("PrecioVenta", typeof(decimal));
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("MontoTotal", typeof(decimal));


            foreach (DataGridViewRow fila in dgvNuevaCompra.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null &&
                    fila.Cells["PrecioCompra"].Value != null &&
                    fila.Cells["PrecioVenta"].Value != null &&
                    fila.Cells["Cantidad"].Value != null &&
                    fila.Cells["Total"].Value != null)
                {
                    tabla.Rows.Add(
                        new object[]
                        {
                            Convert.ToInt32(fila.Cells["IdProducto"].Value),
                            Convert.ToDecimal(fila.Cells["PrecioCompra"].Value),
                            Convert.ToDecimal(fila.Cells["PrecioVenta"].Value),
                            Convert.ToInt32(fila.Cells["Cantidad"].Value),
                            Convert.ToDecimal(fila.Cells["Total"].Value),
                        });
                }
                else
                {
                    MessageBox.Show("Falta información en uno de los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int numeroBoleta = new CD_Compra().NumeroBoleta();

            string idBoleta = string.Format("{0:00000}", numeroBoleta);

            // Obtener IdProveedor basado en el Documento
            int idProveedor = new CD_Proveedor().ObtenerIdProveedorPorDocumento(txtNumeroDocumento.Text);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = usuarioActual.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = idProveedor }, // Asigna el IdProveedor obtenido
                TipoDocumento = ((OpcionCombo)cboTipoDoc.SelectedItem).Texto,
                NumeroDocumento = idBoleta,
                MontoTotal = Convert.ToDecimal(txtTotalCompra.Text),
                FechaRegistro = DateTime.Now.ToString("dd/MM/yyyy")
            };

            try
            {
                new CD_Compra().Registrar(oCompra, tabla);
                MessageBox.Show($"Compra existosa\nNúmero de compra: {idBoleta}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
