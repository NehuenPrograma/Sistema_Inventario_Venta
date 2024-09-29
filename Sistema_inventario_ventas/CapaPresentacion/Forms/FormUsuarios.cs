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
    public partial class FormUsuarios : Form
    {
        private List<Usuario> listaUsuarios;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();
        }

        private void cargar()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                listaUsuarios = negocio.Listar();
                dgvUsuario.DataSource = listaUsuarios;
                dgvUsuario.Columns["IdUsuario"].Visible = false;
                dgvUsuario.Columns["FechaRegistro"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvUsuario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el encabezado de la columna al centro
            dgvUsuario.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ancho automatico
            dgvUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columna 5
            dgvUsuario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // cargar va aca o en btnAceptarUsuario_Click ????
            cargar();


            pnlInfoUsuario.Visible = true;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = true;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            
            pnlInfoUsuario.Visible = false;
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = false;
        }
    }
}
