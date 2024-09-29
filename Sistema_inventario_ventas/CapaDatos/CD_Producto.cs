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
                datos.setearConsulta("Select p.IdProducto, c.Descripcion Categoria, p.Nombre, p.Talle, p.Color, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Codigo From PRODUCTO p, CATEGORIA c Where p.IdCategoria = c.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.oCategoria = new Categoria();
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

        public void modificar()
        {

        }
    }
}
