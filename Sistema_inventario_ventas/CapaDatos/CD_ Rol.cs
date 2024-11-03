using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD__Rol
    {

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdRol, Descripcion From ROL");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rol aux = new Rol();

                    aux.IdRol = (int)datos.Lector["IdRol"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];



                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                lista = new List<Rol>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
