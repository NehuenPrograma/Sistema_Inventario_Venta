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
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdCategoria, Descripcion From CATEGORIA");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];



                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                lista = new List<Categoria>();
                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO Categoria (Descripcion) VALUES (@Descripcion)");
                datos.setearParametro("@Descripcion", categoria.Descripcion);
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
