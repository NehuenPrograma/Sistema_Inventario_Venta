using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdProveedor, RazonSocial, Correo, Telefono, Documento From Proveedor");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.IdProveedor = (int)datos.Lector["IdProveedor"];
                    aux.RazonSocial = (string)datos.Lector["RazonSocial"];
                    aux.Correo = (string)datos.Lector["Correo"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Documento = (string)datos.Lector["Documento"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                lista = new List<Proveedor>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int ObtenerIdProveedorPorDocumento(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            int idProveedor = 0;
            try
            {
                datos.setearConsulta("SELECT IdProveedor FROM Proveedor WHERE Documento = @Documento");
                datos.setearParametro("@Documento", documento);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    idProveedor = (int)datos.Lector["IdProveedor"];
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
            return idProveedor;
        }

        public bool ProveedorExiste(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Proveedor WHERE Documento = @Documento");
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

        public void agregar(Proveedor proveedor)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Proveedor (Documento, RazonSocial, Correo, Telefono, Estado) VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, 1)");
                datos.setearParametro("@Documento", proveedor.Documento);
                datos.setearParametro("@NombreCompleto", proveedor.RazonSocial);
                datos.setearParametro("@Correo", proveedor.Correo);
                datos.setearParametro("@Telefono", proveedor.Telefono);
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
        public void modificar(Proveedor proveedor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Proveedor SET Documento = @Documento, RazonSocial = @RazonSocial, Correo = @Correo, Telefono = @Telefono WHERE IdProveedor = @IdProveedor");
                datos.setearParametro("@Documento", proveedor.Documento);
                datos.setearParametro("@RazonSocial", proveedor.RazonSocial);
                datos.setearParametro("@Correo", proveedor.Correo);
                datos.setearParametro("@Telefono", proveedor.Telefono);
                datos.setearParametro("@IdProveedor", proveedor.IdProveedor);
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
        public void eliminar(int idProveedor)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Proveedor WHERE IdProveedor = @IdProveedor");
                datos.setearParametro("@IdProveedor", idProveedor);
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
        public bool ProveedorRelacionadoConCompras(int idProveedor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Compra WHERE IdProveedor = @IdProveedor");
                datos.setearParametro("@IdProveedor", idProveedor);
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