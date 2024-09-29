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

namespace CapaPresentacion.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = new UsuarioNegocio().Listar();

            Usuario usuario = new UsuarioNegocio().Listar().Where(u => u.Documento == tbxNDocLogin.Text && u.Clave == tbxPasswordLogin.Text).FirstOrDefault();

            if(usuario != null)
            {
                Inicio form = new Inicio(usuario);

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
