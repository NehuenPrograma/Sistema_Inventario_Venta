﻿using System;
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
            string nombreUsuario = tbxNDocLogin.Text;
            string clave = tbxPasswordLogin.Text;


            List<Usuario> listaUsuarios = new UsuarioNegocio().Listar();

            Usuario usuario = new UsuarioNegocio().Listar().Where(u => u.Documento == nombreUsuario && u.Clave == clave).FirstOrDefault();

            if(usuario != null)
            {
                

                Inicio form = new Inicio(usuario);

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto\n Pruebe otra vez", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
