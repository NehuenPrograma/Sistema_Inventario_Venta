using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Forms;
using FontAwesome.Sharp;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Forms
{
    public partial class FormVentas : Form
    {

        private Form formularioActivo;
        private Usuario usuarioActual;

        public FormVentas(Usuario usuario)
        {

            usuarioActual = usuario;

            InitializeComponent();
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

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // Agregamos valores al ComboBox
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDoc.DisplayMember = "Texto";
            cboTipoDoc.ValueMember = "Valor";
            cboTipoDoc.SelectedIndex = 0;

            // Obtenemos la fecha actual
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Validar que no se pueda reescribir !!!
        }
    }
}
