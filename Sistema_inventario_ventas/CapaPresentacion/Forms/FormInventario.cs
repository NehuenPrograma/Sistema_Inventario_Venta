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

namespace CapaPresentacion.Forms
{
    public partial class FormInventario : Form
    {
        private List<Producto> listaProductos;


        private int btnBandera;
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
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
                dgvInventario.Columns["IdProducto"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void leerCategoria()
        {
            CD_Categoria categoria = new CD_Categoria();

            try
            {
                cboCategoria.DataSource = categoria.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = true;
            btnBandera = 0;
            leerCategoria();

            // cargar va aca o en btnAceptarProducto_Click ????
            cargar();
           
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = true;
            btnBandera = 1;
            leerCategoria();



        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            
            
            if (btnBandera == 0)
            {
                Producto nuevo = new Producto();
                CD_Producto negocio = new CD_Producto();

                try
                {
                    nuevo.oCategoria = (Categoria) cboCategoria.SelectedItem;
                    nuevo.Nombre = txtNombreProducto.Text;
                    nuevo.Talle = txtTalleProducto.Text;
                    nuevo.Color = txtColorProducto.Text;
                    nuevo.PrecioCompra = nudPrecioCompraProducto.Value;
                    nuevo.PrecioVenta = nudPrecioVentaProducto.Value;
                    nuevo.Stock = (int)nudStockProducto.Value;
                    nuevo.Codigo = txtCodigoProducto.Text;



                    if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtTalleProducto.Text) && !string.IsNullOrEmpty(txtColorProducto.Text))
                    {
                        negocio.agregar(nuevo);
                        MessageBox.Show("Producto Agregado");
                        cargar();
                        txtNombreProducto.Text = "";
                        txtTalleProducto.Text = "";
                        txtColorProducto.Text = "";
                        nudPrecioCompraProducto.Value = 0;
                        nudPrecioVentaProducto.Value = 0;
                        nudStockProducto.Value = 0;
                        txtCodigoProducto.Text = "";

                        pnlInfoProducto.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Los campos Nombre, Talle y Color son obligatorios");
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else if( btnBandera == 1)
            {
                
            }

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            pnlInfoProducto.Visible = false;
        }

    }
}
