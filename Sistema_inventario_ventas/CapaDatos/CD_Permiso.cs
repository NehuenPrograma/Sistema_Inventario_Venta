using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int id)
        {
            List<Permiso> lista = new List<Permiso>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select p.IdRol, p.NombreMenu From PERMISO p inner join Rol r on r.IdRol = p.IdRol inner join USUARIO u on u.IdRol = r.IdRol Where u.IdUsuario = @IdUsuario");

                datos.setearParametro("@IdUsuario", id);


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Permiso aux = new Permiso();

                    aux.oRol = new Rol();
                    aux.oRol.IdRol = (int)datos.Lector["IdRol"];
                    aux.NombreMenu = (string)datos.Lector["NombreMenu"];
                    


                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                lista = new List<Permiso>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
