using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProveedorNegocio
    {

        private CD_Proveedor proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return proveedor.Listar();
        }
        
    }
}
