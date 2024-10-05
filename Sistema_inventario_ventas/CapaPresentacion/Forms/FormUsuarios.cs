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
using CapaDatos;
using System.Globalization;
using CapaPresentacion.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormUsuarios : Form
    {
        private List<Usuario> listaUsuarios;

        // relacion btnAceptar
        private Usuario usuario = null;

        public FormUsuarios()
        {
            InitializeComponent();

            // Actualizar pnlInfoProducto en Modificar segun se cambie el Producto seleccionado
            dgvUsuario.SelectionChanged += dgvUsuario_SelectionChanged;
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
                dgvUsuario.Columns["IdRol"].Visible = false;
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
        private void ocultarColumnas()
        {
            //dgvUsuario.Columns[""].Visible = false;

        }
        private void leerRol()
        {
            CD__Rol rol = new CD__Rol();

            try
            {
                cboRolUsuario.DataSource = rol.Listar();
                cboRolUsuario.ValueMember = "IdRol";
                cboRolUsuario.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> listaFiltrada;
            string filtro = txtBuscarUsuario.Text;

            if (filtro != "")
            {
                listaFiltrada = listaUsuarios.FindAll(x => x.NombreCompleto.ToUpper().Contains(filtro.ToUpper()) || x.Documento.ToUpper().Contains(filtro.ToUpper())); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaUsuarios;
            }


            //dgvInventario.DataSource = null;
            dgvUsuario.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = true;
            limpiarCamposPanel();
            leerRol();
        }
        private void limpiarCamposPanel()
        {
            // Funcion necesaria para btnAgregarUsuario_Click
            txtNombreUsuario.Clear();
            txtDocumentoUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtClaveUsuario.Clear();
            cboRolUsuario.SelectedItem = null;
            // Limpia los demás campos según sea necesario
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            leerRol();

            if (dgvUsuario.CurrentRow != null && dgvUsuario.CurrentRow.DataBoundItem != null)
            {
                usuario = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
                cargarUsuarioEnPanel(usuario);
                pnlInfoUsuario.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cargarUsuarioEnPanel(Usuario usuario)
        {
            // Obtener el usuario actual ¡¡¡MUY IMPORTANTE!!!
            this.usuario = usuario;

            // Funcion necesaria parabtnModificarProducto_Click
            txtDocumentoUsuario.Text = usuario.Documento;
            txtNombreUsuario.Text = usuario.NombreCompleto;
            txtCorreoUsuario.Text = usuario.Correo;
            txtClaveUsuario.Text = usuario.Clave;
            cboRolUsuario.SelectedItem = usuario.oRol;
        }

        // Actualizar pnlInfoUsuario en Modificar segun se cambie el Producto seleccionado
        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow != null && dgvUsuario.CurrentRow.DataBoundItem != null)
            {
                Usuario seleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
                cargarUsuarioEnPanel(seleccionado);
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e) // VALIDAR QUE NO ESTE RELACIONADO CON VENTAS
        {
            CD_Usuario negocio = new CD_Usuario();
            Usuario seleccionado;

            try
            {
                if (dgvUsuario.CurrentRow != null && dgvUsuario.CurrentRow.DataBoundItem != null)
                {
                    DialogResult respuesta = MessageBox.Show("Desea eliminar el usuario seleccionado, no es reversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
                        try
                        {
                            negocio.eliminar(seleccionado.IdUsuario);
                            MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                    MessageBox.Show("Ningun producto selecionado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = false;
        }

    }
}
