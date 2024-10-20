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
    public partial class ModalProducto : Form
    {
        public Producto _producto { get; set; }

        private List<Producto> listaProductos;

        public ModalProducto()
        {
            InitializeComponent();
        }

        private void ModalProducto_Load(object sender, EventArgs e)
        {
            cargar();
            alinearContenidoCeldas();
        }
        private void cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos = negocio.Listar();
                dgvInventario.DataSource = listaProductos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvInventario.Columns["IdProducto"].Visible = false;

        }

        private void alinearContenidoCeldas()
        {
            // Alinear la columna al centro
            dgvInventario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear la columna a la derecha
            dgvInventario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInventario.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInventario.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Ancho automatico
            dgvInventario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ancho columna 8
            dgvInventario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBuscarProducto.Text;

            if (filtro != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Talle.ToUpper().Contains(filtro.ToUpper()) || x.Color.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.oCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper())); // Agregar todos lo campos necesarios para filtrar
            }
            else
            {
                listaFiltrada = listaProductos;
            }


            //dgvInventario.DataSource = null;
            dgvInventario.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum > 0)
            {
                try
                {
                    _producto = new Producto()
                    {
                        oCategoria = new Categoria()
                        {
                            Descripcion = dgvInventario.Rows[iRow].Cells["oCategoria"].Value?.ToString() ?? string.Empty
                        },
                        Codigo = dgvInventario.Rows[iRow].Cells["Codigo"].Value?.ToString() ?? string.Empty,
                        Nombre = dgvInventario.Rows[iRow].Cells["Nombre"].Value?.ToString() ?? string.Empty,
                        Talle = dgvInventario.Rows[iRow].Cells["Talle"].Value?.ToString() ?? string.Empty,
                        Color = dgvInventario.Rows[iRow].Cells["Color"].Value?.ToString() ?? string.Empty,
                        Stock = int.Parse(dgvInventario.Rows[iRow].Cells["Stock"].Value?.ToString() ?? "0"),
                        PrecioCompra = decimal.Parse(dgvInventario.Rows[iRow].Cells["PrecioCompra"].Value?.ToString() ?? "0"),
                        PrecioVenta = decimal.Parse(dgvInventario.Rows[iRow].Cells["PrecioVenta"].Value?.ToString() ?? "0")
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al seleccionar el producto: {ex.Message}");
                }

            }
        }
    }
}
