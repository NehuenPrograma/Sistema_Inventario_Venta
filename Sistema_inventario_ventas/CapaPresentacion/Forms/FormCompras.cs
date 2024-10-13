using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormCompras : Form
    {

        private Form formularioActivo;


        public FormCompras()
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
