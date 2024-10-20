using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class ModalProveedor : Form
    {
        public Proveedor _proveedor { get; set; }

        private List<Proveedor> listaProveedores;


        public ModalProveedor()
        {
            InitializeComponent();
        }

        private void ModalProveedor_Load(object sender, EventArgs e)
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
            dgvProveedor.Columns["Correo"].Visible = false;
            dgvProveedor.Columns["Telefono"].Visible = false;
            dgvProveedor.Columns["Estado"].Visible = false;
            dgvProveedor.Columns["FechaRegistro"].Visible = false;

        }

        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ancho automatico
            dgvProveedor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columnas
            dgvProveedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _proveedor = new Proveedor()
                {
                    Documento = dgvProveedor.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvProveedor.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
