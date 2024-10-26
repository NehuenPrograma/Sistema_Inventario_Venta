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

    }
}
