using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio obtenerNegocio()
        {
            AccesoDatos datos = new AccesoDatos();
            Negocio aux = new Negocio();

            try
            {
                datos.setearConsulta("Select IdNegocio, Nombre, RUC, Direccion, Logo From NEGOCIO Where IdNegocio = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    aux.IdNegocio = (int)datos.Lector["IdNegocio"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.RUC = (string)datos.Lector["RUC"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Logo = datos.Lector["Logo"] as byte[];


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return aux;

        }

        public void guardarDatos(Negocio negocio, byte[] logo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Si logo es nulo, no actualizamos el campo Logo en la base de datos
                string query = logo != null
                    ? "Update NEGOCIO set Nombre = @Nombre, RUC = @RUC, Direccion = @Direccion, Logo = @Logo Where IdNegocio = @IdNegocio"
                    : "Update NEGOCIO set Nombre = @Nombre, RUC = @RUC, Direccion = @Direccion Where IdNegocio = @IdNegocio";

                datos.setearConsulta(query);

                datos.setearParametro("@IdNegocio", negocio.IdNegocio);
                datos.setearParametro("@Nombre", negocio.Nombre);
                datos.setearParametro("@RUC", negocio.RUC);
                datos.setearParametro("@Direccion", negocio.Direccion);

                if (logo != null)
                {
                    datos.setearParametro("@Logo", logo);
                }

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
