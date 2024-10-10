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
    public partial class FormClientes : Form
    {
        private List<Cliente> listaClientes;

        // relacion btnAceptar
        private Cliente cliente = null;

        private Usuario usuarioActual;

        public FormClientes(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;

            // Actualizar pnlInfoCliente en Modificar segun se cambie el Cliente seleccionado
            dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();

            if (usuarioActual.IdRol == 2)
            {
                desacativarEmpleado();
            }
        }

        private void cargar()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                listaClientes = negocio.Listar();
                dgvCliente.DataSource = listaClientes;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvCliente.Columns["IdCliente"].Visible = false;
            dgvCliente.Columns["Estado"].Visible = false;
            dgvCliente.Columns["FechaRegistro"].Visible = false;

        }

        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ancho automatico
            dgvCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columnas
            dgvCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> listaFiltrada;
            string filtro = txtBuscarCliente.Text;

            if (filtro != "")
            {
                listaFiltrada = listaClientes.FindAll(x => x.NombreCompleto.ToUpper().Contains(filtro.ToUpper()) || x.Documento.ToUpper().Contains(filtro.ToUpper())); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaClientes;
            }

            //dgvInventario.DataSource = null;
            dgvCliente.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            pnlInfoCliente.Visible = true;
            limpiarCamposPanel();
            cliente = new Cliente();
        }

        private void limpiarCamposPanel()
        {
            // Funcion necesaria para btnAgregarCliente_Click
            txtDocumentoCliente.Clear();
            txtNombreCliente.Clear();
            txtCorreoCliente.Clear();
            txtTelCliente.Clear();
            // Limpia los demás campos según sea necesario
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null && dgvCliente.CurrentRow.DataBoundItem != null)
            {
                //Cliente seleccionado;
                //seleccionado = (Cliente)dgvInventario.CurrentRow.DataBoundItem;
                cliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;

                pnlInfoCliente.Visible = true;
                cargarClienteEnPanel(cliente);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Cliente de la lista.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarClienteEnPanel(Cliente cliente)
        {
            // Obtener el Cliente actual ¡¡¡MUY IMPORTANTE!!!
            this.cliente = cliente;

            // Funcion necesaria parabtnModificarCliente_Click
            txtDocumentoCliente.Text = cliente.Documento;
            txtNombreCliente.Text = cliente.NombreCompleto;
            txtCorreoCliente.Text = cliente.Correo;
            txtTelCliente.Text = cliente.Telefono;
            // Asigna los demás campos según sea necesario
        }

        // Actualizar pnlInfoCliente en Modificar segun se cambie el Cliente seleccionado
        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null && dgvCliente.CurrentRow.DataBoundItem != null)
            {
                Cliente seleccionado = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
                cargarClienteEnPanel(seleccionado);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            CD_Cliente negocio = new CD_Cliente();
            Cliente seleccionado;

            try
            {
                if (dgvCliente.CurrentRow != null && dgvCliente.CurrentRow.DataBoundItem != null)
                {
                    DialogResult respuesta = MessageBox.Show("Desea eliminar el Cliente seleccionado, no es reversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.IdCliente);
                        cargar();
                    }
                }
                else
                    MessageBox.Show("Ningun Cliente selecionado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            CD_Cliente negocio = new CD_Cliente();

            try
            {
                if (cliente == null)
                    cliente = new Cliente();

                cliente.Documento = txtDocumentoCliente.Text;
                cliente.NombreCompleto = txtNombreCliente.Text;
                cliente.Correo = txtCorreoCliente.Text;
                cliente.Telefono = txtTelCliente.Text;


                // Validacion de campos 
                if (!string.IsNullOrEmpty(txtDocumentoCliente.Text) && !string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    // Validacion de seleccion Modificar o Agregar
                    if (cliente.IdCliente == 0) // Nuevo cliente
                    {
                        if (negocio.ClienteExiste(cliente.Documento))
                        {
                            MessageBox.Show("El N°Documento ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            negocio.agregar(cliente);
                            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposPanel();
                        }
                    }
                    else // Cliente existente
                    {
                        negocio.modificar(cliente);
                        MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cargar();
                    pnlInfoCliente.Visible = false;

                }
                else
                {
                    MessageBox.Show("Los campos N° Documento, Nombre y Apellido son obligatorios");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            pnlInfoCliente.Visible = false;
        }

        // Deshabiliatar controles para ROL EMPLEADO  CONTROLAR !!!!
        public void desacativarEmpleado()
        {
            btnModificarCliente.Visible = false;
            btnEliminarCliente.Visible = false;
        }
    }
}
