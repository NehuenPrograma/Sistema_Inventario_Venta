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
            dgvDetalleCompra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDetalleCompra.Columns[1].Width = 200;

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
            ModalDetalleCompra modal = new ModalDetalleCompra();
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
            {
                Compra seleccionada = modal._compra;

                txtFecha.Text = seleccionada.FechaRegistro;
                txtTipoDocumento.Text = seleccionada.TipoDocumento;
                txtUsuario.Text = seleccionada.oUsuario.NombreCompleto;
                txtNumDocProveedor.Text = seleccionada.oProveedor.Documento;
                txtNombreProveedor.Text = seleccionada.oProveedor.RazonSocial;
                txtNumeroCompra.Text = seleccionada.NumeroDocumento;
                txtTotalCompra.Text = seleccionada.MontoTotal.ToString("F2");

                // Cargar detalles de la compra en el DataGridView
                dgvDetalleCompra.DataSource = seleccionada.oDetalleCompra;

                // Ajustar las celdas para mostrar la descripción completa del producto
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.Cells["oProducto"].Value is Producto producto)
                    {
                        row.Cells["oProducto"].Value = producto.ToString();
                    }
                }

                alinearContenidoCeldas();
                ocultarColumnas();
            }
        }

    }
}
