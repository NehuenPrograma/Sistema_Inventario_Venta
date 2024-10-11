using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;

namespace CapaPresentacion.Forms
{
    public partial class FormNegocio : Form
    {
        public FormNegocio()
        {
            InitializeComponent();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void FormNegocio_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del negocio
                CD_Negocio cdNegocio = new CD_Negocio();
                Negocio negocio = cdNegocio.obtenerNegocio();

                if (negocio != null)
                {
                    txtNombre.Text = negocio.Nombre;
                    txtRUC.Text = negocio.RUC;
                    txtDireccion.Text = negocio.Direccion;

                    // Intentar cargar la imagen
                    try
                    {
                        if (negocio.Logo != null && negocio.Logo.Length > 0)
                        {
                            using (var ms = new MemoryStream(negocio.Logo))
                            {
                                pbLogo.Image = Image.FromStream(ms);
                                pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una imagen en la base de datos.");
                        }
                    }
                    catch (Exception imgEx)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + imgEx.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el negocio en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del negocio: " + ex.Message);
            }
        }

        private void btnAgregarLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio negocio = new Negocio();
                negocio.IdNegocio = 1; // Asegúrate de que este ID sea el correcto
                negocio.Nombre = txtNombre.Text;
                negocio.RUC = txtRUC.Text;
                negocio.Direccion = txtDireccion.Text;

                byte[] logo = null;
                bool actualizarLogo = false;

                if (pbLogo.Image != null)
                {
                    // Solo convertimos la imagen si hay una imagen en pbLogo
                    logo = ImageToByteArray(pbLogo.Image);
                    actualizarLogo = true;
                }

                CD_Negocio datosNegocio = new CD_Negocio();
                datosNegocio.guardarDatos(negocio, actualizarLogo ? logo : null);

                MessageBox.Show("Datos guardados exitosamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);

            }
        }
    }
}
