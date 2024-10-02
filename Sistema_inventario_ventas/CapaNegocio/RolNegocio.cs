using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class RolNegocio
    {
        private CD__Rol rol = new CD__Rol();

        public List<Rol> Listar()
        {
            return rol.Listar();
        }
    }
}
