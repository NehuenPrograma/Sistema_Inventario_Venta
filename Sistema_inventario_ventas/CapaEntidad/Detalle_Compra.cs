using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int IdDetalleCompra { get; set; }

        [DisplayName("Producto")]
        public Producto oProducto { get; set; }

        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Precio venta")]
        public decimal PrecioVenta { get; set; }

        public int Cantidad { get; set; }

        [DisplayName("Monto")]
        public decimal MontoTotal { get; set; }


        public string FechaRegistro { get; set; }
    }
}
