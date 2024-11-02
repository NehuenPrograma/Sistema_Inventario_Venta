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
using CapaDatos;

namespace CapaPresentacion.Modales
{
    public partial class ModalDetalleCompra : Form
    {
        public Compra _compra { get; set; }

        private List<Compra> listaCompras;

        public ModalDetalleCompra()
        {
            InitializeComponent();
            this.Load += ModalDetalleCompra_Load;
            dgvCompra.CellDoubleClick += dgvCompra_CellDoubleClick;
        }

        private void ModalDetalleCompra_Load(object sender, EventArgs e)
        {
            cargar();
            dgvCompra.DataBindingComplete += dgvCompra_DataBindingComplete;
        }
        private void cargar()
        {
            CD_Compra negocio = new CD_Compra();
            try
            {
                listaCompras = negocio.Listar();
                dgvCompra.DataSource = listaCompras;
                ocultarColumnas();
                alinearContenidoCeldas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                if (row.Cells["Usuario"].Value is Usuario usuario)
                {
                    row.Cells["Usuario"].Value = usuario.NombreCompleto;
                }

                if (row.Cells["Proveedor"].Value is Proveedor proveedor)
                {
                    row.Cells["Proveedor"].Value = proveedor.RazonSocial;
                }
            }
        }

        private void ocultarColumnas()
        {
            dgvCompra.Columns["IdCompra"].Visible = false;

        }

        private void alinearContenidoCeldas()
        {
            // Alinear todas las columnas al centro
            foreach (DataGridViewColumn column in dgvCompra.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Establecer el ancho de las columnas de manera equitativa para ocupar todo el espacio del DataGridView
            foreach (DataGridViewColumn column in dgvCompra.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Alinear los encabezados al centro
            foreach (DataGridViewColumn column in dgvCompra.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void txtBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            List<Compra> listaFiltrada;
            string filtro = txtBuscarCompra.Text;

            if (filtro != "")
            {
                listaFiltrada = listaCompras.FindAll(x => x.NumeroDocumento.ToUpper().Contains(filtro.ToUpper()) || x.TipoDocumento.ToUpper().Contains(filtro.ToUpper()) || x.oProveedor.RazonSocial.ToUpper().Contains(filtro.ToUpper()) || x.oUsuario.NombreCompleto.ToUpper().Contains(filtro.ToUpper()) ); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaCompras;
            }


            //dgvInventario.DataSource = null;
            dgvCompra.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void dgvCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            if (iRow >= 0)
            {
                try
                {
                    Compra compraSeleccionada = (Compra)dgvCompra.Rows[iRow].DataBoundItem;
                    _compra = compraSeleccionada;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al seleccionar la compra: {ex.Message}");
                }
            }
        }
    }
}
