using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int NumeroBoleta()
        {
            int numero = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select count(*) + 1 From COMPRA");
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    numero = (int)datos.Lector[0];
                }
                return numero;
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

        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT c.IdCompra, u.IdUsuario, u.NombreCompleto as Usuario, p.IdProveedor, p.RazonSocial as Proveedor, " +
                                     "c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, c.FechaRegistro " +
                                     "FROM COMPRA c " +
                                     "INNER JOIN USUARIO u ON c.IdUsuario = u.IdUsuario " +
                                     "INNER JOIN PROVEEDOR p ON c.IdProveedor = p.IdProveedor");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Compra compra = new Compra
                    {
                        IdCompra = (int)datos.Lector["IdCompra"],
                        oUsuario = new Usuario { IdUsuario = (int)datos.Lector["IdUsuario"], NombreCompleto = (string)datos.Lector["Usuario"] },
                        oProveedor = new Proveedor { IdProveedor = (int)datos.Lector["IdProveedor"], RazonSocial = (string)datos.Lector["Proveedor"] },
                        TipoDocumento = (string)datos.Lector["TipoDocumento"],
                        NumeroDocumento = (string)datos.Lector["NumeroDocumento"],
                        MontoTotal = (decimal)datos.Lector["MontoTotal"],
                        FechaRegistro = (string)datos.Lector["FechaRegistro"],
                        oDetalleCompra = new List<Detalle_Compra>()
                    };

                    datos.setearConsulta("SELECT dc.IdDetalleCompra, dc.IdProducto, p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal, dc.FechaRegistro " +
                                         "FROM DETALLE_COMPRA dc " +
                                         "INNER JOIN PRODUCTO p ON dc.IdProducto = p.IdProducto " +
                                         "WHERE dc.IdCompra = @IdCompra");
                    datos.setearParametro("@IdCompra", compra.IdCompra);

                    datos.ejecutarLectura();
                    while (datos.Lector.Read())
                    {
                        Detalle_Compra detalle = new Detalle_Compra
                        {
                            IdDetalleCompra = (int)datos.Lector["IdDetalleCompra"],
                            oProducto = new Producto { IdProducto = (int)datos.Lector["IdProducto"], Nombre = (string)datos.Lector["Nombre"] },
                            PrecioCompra = (decimal)datos.Lector["PrecioCompra"],
                            Cantidad = (int)datos.Lector["Cantidad"],
                            MontoTotal = (decimal)datos.Lector["MontoTotal"],
                            FechaRegistro = (string)datos.Lector["FechaRegistro"]
                        };
                        compra.oDetalleCompra.Add(detalle);
                    }

                    lista.Add(compra);
                }
                return lista;
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

        public void AgregarDetalleCompra(int idCompra, DataTable tabla)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                foreach (DataRow row in tabla.Rows)
                {
                    datos.setearConsulta("INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro) " +
                                         "VALUES (@IdCompra, @IdProducto, @PrecioCompra, @PrecioVenta, @Cantidad, @MontoTotal, @FechaRegistro)");
                    datos.setearParametro("@IdCompra", idCompra);
                    datos.setearParametro("@IdProducto", Convert.ToInt32(row["IdProducto"]));
                    datos.setearParametro("@PrecioCompra", Convert.ToDecimal(row["PrecioCompra"]));
                    datos.setearParametro("@PrecioVenta", Convert.ToDecimal(row["PrecioVenta"]));
                    datos.setearParametro("@Cantidad", Convert.ToInt32(row["Cantidad"]));
                    datos.setearParametro("@MontoTotal", Convert.ToDecimal(row["MontoTotal"]));
                    datos.setearParametro("@FechaRegistro", DateTime.Now);

                    datos.ejecutarAccion();

                    // Log de depuración
                    Console.WriteLine($"Detalle Insertado - IdCompra: {idCompra}, IdProducto: {row["IdProducto"]}, PrecioCompra: {row["PrecioCompra"]}, PrecioVenta: {row["PrecioVenta"]}, Cantidad: {row["Cantidad"]}, MontoTotal: {row["MontoTotal"]}");
                }
            }
            catch (Exception ex)
            {
                // Log de depuración de errores
                Console.WriteLine($"Error al insertar detalle: {ex.Message}");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Registrar(Compra compra, DataTable tabla)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Insertar la compra y obtener el Id de la compra recién creada
                datos.setearConsulta("INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal) " +
                                     "OUTPUT INSERTED.IdCompra VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)");
                datos.setearParametro("@IdUsuario", compra.oUsuario.IdUsuario);
                datos.setearParametro("@IdProveedor", compra.oProveedor.IdProveedor);
                datos.setearParametro("@TipoDocumento", compra.TipoDocumento);
                datos.setearParametro("@NumeroDocumento", compra.NumeroDocumento);
                datos.setearParametro("@MontoTotal", compra.MontoTotal);

                datos.ejecutarLectura();
                int idCompra = 0;
                if (datos.Lector.Read())
                {
                    idCompra = Convert.ToInt32(datos.Lector["IdCompra"]);
                }
                datos.cerrarConexion(); // Cerrar conexión después de obtener el IdCompra

                if (idCompra == 0)
                {
                    throw new Exception("Error al obtener IdCompra.");
                }

                // Registrar cada producto de la compra en la tabla DETALLE_COMPRA
                int detalleIndex = 0;
                foreach (DataRow row in tabla.Rows)
                {
                    datos.setearConsulta($"INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal) " +
                                         $"VALUES (@IdCompra{detalleIndex}, @IdProducto{detalleIndex}, @PrecioCompra{detalleIndex}, @PrecioVenta{detalleIndex}, @Cantidad{detalleIndex}, @MontoTotal{detalleIndex})");
                    datos.setearParametro($"@IdCompra{detalleIndex}", idCompra);
                    datos.setearParametro($"@IdProducto{detalleIndex}", Convert.ToInt32(row["IdProducto"]));
                    datos.setearParametro($"@PrecioCompra{detalleIndex}", Convert.ToDecimal(row["PrecioCompra"]));
                    datos.setearParametro($"@PrecioVenta{detalleIndex}", Convert.ToDecimal(row["PrecioVenta"]));
                    datos.setearParametro($"@Cantidad{detalleIndex}", Convert.ToInt32(row["Cantidad"]));
                    datos.setearParametro($"@MontoTotal{detalleIndex}", Convert.ToDecimal(row["MontoTotal"]));

                    datos.ejecutarAccion();
                    datos.limpiarParametros(); // Limpiar parámetros después de cada ejecución
                    datos.cerrarConexion(); // Cerrar conexión después de cada ejecución de acción
                    detalleIndex++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar los detalles de la compra: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
