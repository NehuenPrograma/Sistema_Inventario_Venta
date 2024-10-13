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

namespace CapaPresentacion.Forms
{
    public partial class FormVentas : Form
    {

        private Form formularioActivo;


        public FormVentas()
        {
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
    }
}
