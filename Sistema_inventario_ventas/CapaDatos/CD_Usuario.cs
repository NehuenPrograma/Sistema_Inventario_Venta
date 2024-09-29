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
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, r.Descripcion From USUARIO u, ROL r Where u.IdRol = r.IdRol");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = (int)datos.Lector["IdUsuario"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.NombreCompleto = (string)datos.Lector["NombreCompleto"];
                    aux.Correo = (string)datos.Lector["Correo"];
                    aux.Clave = (string)datos.Lector["Clave"];
                    aux.oRol = new Rol();
                    aux.oRol.Descripcion = (string)datos.Lector["Descripcion"];


                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                lista = new List<Usuario>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
