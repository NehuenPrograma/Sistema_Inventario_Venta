using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private CD_Producto producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return producto.Listar();
        }
    }
}
