using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdCliente, Documento, NombreCompleto, Correo, Telefono From CLIENTE");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.NombreCompleto = (string)datos.Lector["NombreCompleto"];
                    aux.Correo = (string)datos.Lector["Correo"];
                    aux.Telefono = (string)datos.Lector["Telefono"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                lista = new List<Cliente>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool ClienteExiste(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Cliente WHERE Documento = @Documento");
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

        public void agregar(Cliente cliente)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Cliente (Documento, NombreCompleto, Correo, Telefono, Estado) VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, 1)");
                datos.setearParametro("@Documento", cliente.Documento);
                datos.setearParametro("@NombreCompleto", cliente.NombreCompleto);
                datos.setearParametro("@Correo", cliente.Correo);
                datos.setearParametro("@Telefono", cliente.Telefono);
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
        public void modificar(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Cliente SET Documento = @Documento, NombreCompleto = @NombreCompleto, Correo = @Correo, Telefono = @Telefono WHERE IdCliente = @IdCliente");
                datos.setearParametro("@Documento", cliente.Documento);
                datos.setearParametro("@NombreCompleto", cliente.NombreCompleto);
                datos.setearParametro("@Correo", cliente.Correo);
                datos.setearParametro("@Telefono", cliente.Telefono);
                datos.setearParametro("@IdCliente", cliente.IdCliente);
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
        public void eliminar(int idCliente)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Cliente WHERE IdCliente = @IdCliente");
                datos.setearParametro("@IdCliente", idCliente);
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
        public bool ClienteRelacionadoConCompras(int idCliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Compra WHERE IdCliente = @IdCliente");
                datos.setearParametro("@IdCliente", idCliente);
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
