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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaPresentacion.Forms
{
    public partial class FormDetalleCompra : Form
    {

        private Form formularioActivo;
        private Usuario usuarioActual;


        public FormDetalleCompra(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();

            // Conectar el evento con el botón `btnNuevaCompra`
            //btnNuevaCompra.Click += btnNuevaCompra_Click;
            // Conectar el evento con el botón `btnBuscar`
            //btnBuscar.Click += btnBuscar_Click;
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            dgvDetalleCompra.DataError += new DataGridViewDataErrorEventHandler(dgvDetalleCompra_DataError);
        }


        private void alinearContenidoCeldas()
        {
            // Alinear todas las columnas al centro
            foreach (DataGridViewColumn column in dgvDetalleCompra.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Establecer el ancho de las columnas de manera equitativa para ocupar todo el espacio del DataGridView
            foreach (DataGridViewColumn column in dgvDetalleCompra.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Establecer el ancho de la columna Producto
            dgvDetalleCompra.Columns["ProductoDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDetalleCompra.Columns["ProductoDescripcion"].Width = 200;

            // Alinear los encabezados al centro
            foreach (DataGridViewColumn column in dgvDetalleCompra.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }
        private void ocultarColumnas()
        {
            dgvDetalleCompra.Columns["IdDetalleCompra"].Visible = false;

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

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormCompras(usuarioActual));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ModalDetalleCompra modal = new ModalDetalleCompra();
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Compra seleccionada = modal._compra;

                    txtIdCompra.Text = seleccionada.IdCompra.ToString();

                    txtFecha.Text = seleccionada.FechaRegistro;
                    txtTipoDocumento.Text = seleccionada.TipoDocumento;
                    txtUsuario.Text = seleccionada.oUsuario.NombreCompleto;
                    txtNumDocProveedor.Text = seleccionada.oProveedor.Documento;
                    txtNombreProveedor.Text = seleccionada.oProveedor.RazonSocial;
                    txtNumeroCompra.Text = seleccionada.NumeroDocumento;
                    txtTotalCompra.Text = seleccionada.MontoTotal.ToString("F2");

                    try
                    {
                        // Cargar detalles de la compra en el DataGridView
                        dgvDetalleCompra.DataSource = seleccionada.oDetalleCompra;

                        // Agregar una nueva columna personalizada para la representación de Producto
                        if (!dgvDetalleCompra.Columns.Contains("ProductoDescripcion"))
                        {
                            DataGridViewTextBoxColumn descripcionColumna = new DataGridViewTextBoxColumn
                            {
                                Name = "ProductoDescripcion",
                                HeaderText = "Producto",
                                DataPropertyName = "ProductoDescripcion",
                                ReadOnly = true,
                                Width = 200 // Establecer el ancho de la columna
                            };
                            dgvDetalleCompra.Columns.Insert(0, descripcionColumna);
                        }

                        // Ajustar las celdas para mostrar la descripción completa del producto
                        foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                        {
                            if (row.Cells["oProducto"].Value is Producto producto)
                            {
                                row.Cells["ProductoDescripcion"].Value = producto.ToString();
                            }
                        }

                        // Hacer la columna original 'oProducto' invisible
                        dgvDetalleCompra.Columns["oProducto"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar detalles de la compra: " + ex.Message);
                    }

                    alinearContenidoCeldas();
                    ocultarColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void dgvDetalleCompra_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine($"DataError en la columna {dgvDetalleCompra.Columns[e.ColumnIndex].Name}, fila {e.RowIndex}: {e.Exception.Message}");
            e.ThrowException = false;
            e.Cancel = true;
        }

        private Compra ObtenerCompraSeleccionada()
        {
            ModalDetalleCompra modal = new ModalDetalleCompra();
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
            {
                return modal._compra;
            }
            return null;
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCompra.Text))
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idCompraSeleccionada;
            if (!int.TryParse(txtIdCompra.Text, out idCompraSeleccionada))
            {
                MessageBox.Show("ID de compra no válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compra compraSeleccionada = new CD_Compra().ObtenerCompraPorId(idCompraSeleccionada);

            if (compraSeleccionada == null)
            {
                MessageBox.Show("No se encontró ninguna compra con ese ID", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            string Texto_HTML = Properties.Resources.PlantillaCompra.ToString();

            Negocio datos = new CD_Negocio().obtenerNegocio();

            // Obtener la imagen del logo como una cadena Base64
            string logoBase64 = datos.Logo != null ? Convert.ToBase64String(datos.Logo) : string.Empty;
            string imgTag = !string.IsNullOrEmpty(logoBase64) ? $"<img src='data:image/png;base64,{logoBase64}' width='150' height='150' />" : string.Empty;

            // Reemplazar el marcador de posición con la etiqueta de imagen
            Texto_HTML = Texto_HTML.Replace("@LogoImage", imgTag);
            Texto_HTML = Texto_HTML.Replace("@NombreNegocio", datos.Nombre.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@DireccionNegocio", datos.Direccion.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@DocNegocio", datos.RUC);

            Texto_HTML = Texto_HTML.Replace("@Fecha", txtFecha.Text.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@NumeroBoleta", txtNumeroCompra.Text.ToUpper());
            
            // Reemplazar los datos del proveedor
            if (compraSeleccionada?.oProveedor != null)
            {
                Texto_HTML = Texto_HTML.Replace("@NombreProveedor", compraSeleccionada.oProveedor.RazonSocial);
                Texto_HTML = Texto_HTML.Replace("@Cuit", compraSeleccionada.oProveedor.Documento);
                Texto_HTML = Texto_HTML.Replace("@CorreoProveedor", compraSeleccionada.oProveedor.Correo);
            }

            // Verificación adicional para asegurarse de que oUsuario no sea null
            if (compraSeleccionada?.oUsuario != null)
            {
                Texto_HTML = Texto_HTML.Replace("@NombreUsuario", txtUsuario.Text);
            }

            //string filas = string.Empty;
            //
            //foreach (DataGridView row in dgvDetalleCompra.Rows)
            //{
            //    filas += "<tr>";
            //    filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["MontoTotal"].Value.ToString() + "</td>";
            //    filas += "</tr>";
            //}

            string productosHTML = "";
            foreach (var detalle in compraSeleccionada.oDetalleCompra)
            {
                productosHTML += "<tr>";
                productosHTML += $"<td>Codigo: {detalle.oProducto.Codigo}<br />  {detalle.oProducto.Nombre},  {detalle.oProducto.Talle},  {detalle.oProducto.Color}</td>";
                productosHTML += $"<td>{detalle.Cantidad}</td>";
                productosHTML += $"<td>{detalle.PrecioVenta}</td>";
                productosHTML += $"<td>{detalle.MontoTotal}</td>";
                productosHTML += "</tr>";
            }
            Texto_HTML = Texto_HTML.Replace("@filas", productosHTML);
            Texto_HTML = Texto_HTML.Replace("@MontoTotal", txtTotalCompra.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", compraSeleccionada.NumeroDocumento);
            savefile.Filter = "Pdf Files |*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream);
                    pdf.Open();

                    Negocio negocio = new CD_Negocio().obtenerNegocio();
                    byte[] logo = negocio.Logo;

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(logo);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdf.Left, pdf.GetTop(51));
                    pdf.Add(img);

                    using (StringReader reader = new StringReader(Texto_HTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, reader);
                    }

                    pdf.Close();
                    stream.Close();

                    MessageBox.Show("Documento Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
