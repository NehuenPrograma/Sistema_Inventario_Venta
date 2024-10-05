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
                datos.setearConsulta("Select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.IdRol, r.Descripcion, r.IdRol From USUARIO u, ROL r Where u.IdRol = r.IdRol");
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

                    aux.IdRol = (int)datos.Lector["IdRol"];


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

        public bool UsuarioExiste(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Usuario WHERE Documento = @Documento");
                datos.setearParametro("@Documento", documento);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return (int)datos.Lector[0] > 0;
                }
                return false;
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

        public void agregar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Usuario (Documento, NombreCompleto, Correo, Clave, IdRol) VALUES (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol)");
                datos.setearParametro("@Documento", usuario.Documento);
                datos.setearParametro("@NombreCompleto", usuario.NombreCompleto);
                datos.setearParametro("@Correo", usuario.Correo);
                datos.setearParametro("@Clave", usuario.Clave);
                datos.setearParametro("@IdRol", usuario.IdRol);
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
        public void modificar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Usuario SET Documento = @Documento, NombreCompleto = @NombreCompleto, Correo = @Correo, Clave = @Clave, IdRol = @IdRol, FechaRegistro = @FechaRegistro WHERE IdUsuario = @IdUsuario");
                datos.setearParametro("@Documento", usuario.Documento);
                datos.setearParametro("@NombreCompleto", usuario.NombreCompleto);
                datos.setearParametro("@Correo", usuario.Correo);
                datos.setearParametro("@Clave", usuario.Clave);
                datos.setearParametro("@IdRol", usuario.IdRol);
                datos.setearParametro("@FechaRegistro", usuario.FechaRegistro);
                datos.setearParametro("@IdUsuario", usuario.IdUsuario);
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
        public void eliminar(int idUsuario)
        {
            if (UsuarioRelacionadoConVentas(idUsuario))
            {
                throw new Exception("No se puede eliminar el usuario porque está relacionado con ventas.");
            }

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Usuario WHERE IdUsuario = @IdUsuario");
                datos.setearParametro("@IdUsuario", idUsuario);
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
        public bool UsuarioRelacionadoConVentas(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Venta WHERE IdUsuario = @IdUsuario");
                datos.setearParametro("@IdUsuario", idUsuario);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return (int)datos.Lector[0] > 0;
                }
                return false;
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