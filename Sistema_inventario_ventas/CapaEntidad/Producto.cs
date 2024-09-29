using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }

        // oCategoria == objeto de Categoria
        [DisplayName("Categoría")]
        public Categoria oCategoria { get; set; }

        public string Nombre { get; set; }

        public string Talle { get; set; }

        public string Color { get; set; }

        public int Stock { get; set; }

        [DisplayName("P Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("P Venta")]
        public decimal PrecioVenta { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        

    }
}
