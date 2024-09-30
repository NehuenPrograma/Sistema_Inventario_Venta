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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select p.IdProducto, c.Descripcion Categoria, p.Nombre, p.Talle, p.Color, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Codigo, c.IdCategoria From PRODUCTO p, CATEGORIA c Where p.IdCategoria = c.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.oCategoria = new Categoria();
                    aux.oCategoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.oCategoria.Descripcion = (string)datos.Lector["Categoria"];

                    
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Talle = (string)datos.Lector["Talle"];
                    aux.Color = (string)datos.Lector["Color"];
                    aux.Stock = (int)datos.Lector["Stock"];


                    aux.PrecioCompra = (decimal)datos.Lector["PrecioCompra"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioVenta"];
                    aux.Codigo = (string)datos.Lector["Codigo"];


                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                lista = new List<Producto>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert Into PRODUCTO (IdCategoria, Nombre, Talle, Color, Stock, PrecioCompra, PrecioVenta, Codigo, Estado) values (@IdCategoria, @Nombre, @Talle, @Color, @Stock, @PrecioCompra, @PrecioVenta, @Codigo, 1)");

                datos.setearParametro("@IdCategoria", nuevo.oCategoria.IdCategoria);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Talle", nuevo.Talle);
                datos.setearParametro("@Color", nuevo.Color);
                datos.setearParametro("@Stock", nuevo.Stock);
                datos.setearParametro("@PrecioCompra", nuevo.PrecioCompra);
                datos.setearParametro("@PrecioVenta", nuevo.PrecioVenta);
                datos.setearParametro("@Codigo", nuevo.Codigo);

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

        public void modificar(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update PRODUCTO set IdCategoria = @IdCategoria, Nombre = @Nombre, Talle = @Talle, Color = @Color, Stock = @Stock, PrecioCompra = @Compra, PrecioVenta = @Venta, Codigo = @Codigo, Estado = 1 Where IdProducto = @IdProducto");

                datos.setearParametro("@IdCategoria", producto.oCategoria.IdCategoria);
                datos.setearParametro("@Nombre", producto.Nombre);
                datos.setearParametro("@Talle", producto.Talle);
                datos.setearParametro("@Color", producto.Color);
                datos.setearParametro("@Stock", producto.Stock);
                datos.setearParametro("@Compra", producto.PrecioCompra);
                datos.setearParametro("@Venta", producto.PrecioVenta);
                datos.setearParametro("@Codigo", producto.Codigo);
                datos.setearParametro("@IdProducto", producto.IdProducto);

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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete From PRODUCTO Where IdProducto = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void sumarStock(int idProducto, int stock)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE PRODUCTO SET Stock = Stock + @Cantidad WHERE IdProducto = @IdProducto");
                datos.setearParametro("@Cantidad", stock);
                datos.setearParametro("@IdProducto", idProducto);
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
        public void restarStock(int idProducto, int stock)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE PRODUCTO SET Stock = Stock - @Cantidad WHERE IdProducto = @IdProducto");
                datos.setearParametro("@Cantidad", stock);
                datos.setearParametro("@IdProducto", idProducto);
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
