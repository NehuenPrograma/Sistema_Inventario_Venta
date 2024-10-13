using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Forms;
using FontAwesome.Sharp;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Campos
        private IconButton botonActivo;
        private Panel leftBorderBtn;
        private Form formularioActivo;

        //
        private static Usuario usuarioActual;

        //Constructor
        public Inicio(Usuario usuario)
        {
            usuarioActual = usuario;

            //
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBorderBtn);

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        //carga de LOAD

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Mostrar nombre de usuario
            lblNombreUsuario.Text = usuarioActual.NombreCompleto;

            //Obtener permisos
            List<Permiso> listaPermisos = new PermisoNegocio().Listar(usuarioActual.IdUsuario);
            //Mostrar Formularios permitidos

            foreach (Control boton in pnlMenu.Controls)
            {
                bool encontrado = listaPermisos.Any(b => b.NombreMenu == boton.Name);

                if (encontrado == false)
                {
                    
                    boton.Visible = false;
                }
            }
            pnlLogo.Visible = true;




        }

        //Estructura para colores
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(245,255,76);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
            public static Color color7 = Color.FromArgb(85,216,125);
            public static Color color8 = Color.FromArgb(255, 203, 92); // BUSCAR UN COLOR
        }


        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {

            if(senderBtn != null)
            {
                DisableButton();

                //Boton
                botonActivo = (IconButton)senderBtn;
                botonActivo.BackColor = Color.FromArgb(37,36,81);
                botonActivo.ForeColor = color;
                botonActivo.TextAlign = ContentAlignment.MiddleCenter;
                botonActivo.IconColor = color;
                botonActivo.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActivo.ImageAlign = ContentAlignment.MiddleRight;

                //Borde Izquierdo 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, botonActivo.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono Hijo Actual 
                iconCurrentChildForm.IconChar = botonActivo.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(botonActivo != null)
            {
                botonActivo.BackColor = Color.FromArgb(31, 30, 68);
                botonActivo.ForeColor = Color.Gainsboro;
                botonActivo.TextAlign = ContentAlignment.MiddleLeft;
                botonActivo.IconColor = Color.Gainsboro;
                botonActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActivo.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm( Form formulario)
        {
            if (formularioActivo != null)
            {

                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            pnlDesktop.Controls.Add(formulario);
            pnlDesktop.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
            lblTitleChildForm.Text = formulario.Text;         

        }

        

        // Metodo Reset clik en logo
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Home";
        }


        // Apertura de Forms

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormUsuarios());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormInventario(usuarioActual));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormVentas());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormCompras());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormClientes(usuarioActual));
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormProveedores());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new FormReportes());
        }
        private void btnNegocio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormNegocio());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Resolver conflicto !!!!!
            formularioActivo.Close();
            Reset();
        }



        // no me acuerdo pero sirve ja

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        // botones minimizar maximizar y exit
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
