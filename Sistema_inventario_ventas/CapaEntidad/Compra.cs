using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        
        // oUsuario == objeto de Usuario
        [DisplayName("Usuario")]
        public Usuario oUsuario { get; set; }


        // oProveedor == objeto de Proveedor
        [DisplayName("Proveedor")]
        public Proveedor oProveedor { get; set; }

        [DisplayName("Número Boleta")]
        public string NumeroDocumento { get; set; }

        [DisplayName("Número Boleta")]
        public string TipoDocumento { get; set; }

        [DisplayName("Monto Total")]
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> oDetalleCompra { get; set; }

        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; }



    }
}
