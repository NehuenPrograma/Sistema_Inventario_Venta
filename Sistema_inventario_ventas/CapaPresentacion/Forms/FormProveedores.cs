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

namespace CapaPresentacion.Forms
{
    public partial class FormProveedores : Form
    {
        private List<Proveedor> listaProveedores;

        // relacion btnAceptar
        private Proveedor proveedor = null;

        private Usuario usuarioActual;

        public FormProveedores()
        {
            InitializeComponent();

            // Actualizar pnlInfoProveedor en Modificar segun se cambie el Proveedor seleccionado
            dgvProveedor.SelectionChanged += dgvProveedor_SelectionChanged;
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();
        }
        private void cargar()
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                listaProveedores = negocio.Listar();
                dgvProveedor.DataSource = listaProveedores;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvProveedor.Columns["IdProveedor"].Visible = false;
            dgvProveedor.Columns["Estado"].Visible = false;
            dgvProveedor.Columns["FechaRegistro"].Visible = false;

        }

        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ancho automatico
            dgvProveedor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columnas
            dgvProveedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            List<Proveedor> listaFiltrada;
            string filtro = txtBuscarProveedor.Text;

            if (filtro != "")
            {
                listaFiltrada = listaProveedores.FindAll(x => x.RazonSocial.ToUpper().Contains(filtro.ToUpper()) || x.Documento.ToUpper().Contains(filtro.ToUpper())); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaProveedores;
            }

            //dgvInventario.DataSource = null;
            dgvProveedor.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            pnlInfoProveedor.Visible = true;
            limpiarCamposPanel();
            proveedor = new Proveedor();
        }
        private void limpiarCamposPanel()
        {
            // Funcion necesaria para btnAgregarProveedor_Click
            txtDocumentoProveedor.Clear();
            txtNombreProveedor.Clear();
            txtCorreoProveedor.Clear();
            txtTelProveedor.Clear();
            // Limpia los demás campos según sea necesario
        }
        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null && dgvProveedor.CurrentRow.DataBoundItem != null)
            {
                //Proveedor seleccionado;
                //seleccionado = (Proveedor)dgvInventario.CurrentRow.DataBoundItem;
                proveedor = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;

                pnlInfoProveedor.Visible = true;
                cargarProveedorEnPanel(proveedor);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Proveedor de la lista.", "Proveedor no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cargarProveedorEnPanel(Proveedor Proveedor)
        {
            // Obtener el Proveedor actual ¡¡¡MUY IMPORTANTE!!!
            this.proveedor = Proveedor;

            // Funcion necesaria parabtnModificarProveedor_Click
            txtDocumentoProveedor.Text = Proveedor.Documento;
            txtNombreProveedor.Text = Proveedor.RazonSocial;
            txtCorreoProveedor.Text = Proveedor.Correo;
            txtTelProveedor.Text = Proveedor.Telefono;
            // Asigna los demás campos según sea necesario
        }
        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null && dgvProveedor.CurrentRow.DataBoundItem != null)
            {
                Proveedor seleccionado = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                cargarProveedorEnPanel(seleccionado);
            }
        }
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            CD_Proveedor negocio = new CD_Proveedor();
            Proveedor seleccionado;

            try
            {
                if (dgvProveedor.CurrentRow != null && dgvProveedor.CurrentRow.DataBoundItem != null)
                {
                    DialogResult respuesta = MessageBox.Show("Desea eliminar el Proveedor seleccionado, no es reversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.IdProveedor);
                        cargar();
                    }
                }
                else
                    MessageBox.Show("Ningun Proveedor selecionado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarProveedor_Click(object sender, EventArgs e)
        {
            CD_Proveedor negocio = new CD_Proveedor();

            try
            {
                if (proveedor == null)
                    proveedor = new Proveedor();

                proveedor.Documento = txtDocumentoProveedor.Text;
                proveedor.RazonSocial = txtNombreProveedor.Text;
                proveedor.Correo = txtCorreoProveedor.Text;
                proveedor.Telefono = txtTelProveedor.Text;


                // Validacion de campos 
                if (!string.IsNullOrEmpty(txtNombreProveedor.Text) && !string.IsNullOrEmpty(txtTelProveedor.Text))
                {
                    // Validacion de seleccion Modificar o Agregar
                    if (proveedor.IdProveedor == 0) // Nuevo Proveedor
                    {
                        if (negocio.ProveedorExiste(proveedor.Documento))
                        {
                            MessageBox.Show("El N°Documento ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            negocio.agregar(proveedor);
                            MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposPanel();
                        }
                    }
                    else // Proveedor existente
                    {
                        negocio.modificar(proveedor);
                        MessageBox.Show("Proveedor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cargar();
                    pnlInfoProveedor.Visible = false;

                }
                else
                {
                    MessageBox.Show("Los campos Razon social y Telefono son obligatorios");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            pnlInfoProveedor.Visible = false;
        }

    }
}
