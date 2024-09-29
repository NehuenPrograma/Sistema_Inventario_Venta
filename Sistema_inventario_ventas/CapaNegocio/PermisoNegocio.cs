using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class PermisoNegocio
    {
        private CD_Permiso permiso = new CD_Permiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            return permiso.Listar(IdUsuario);
        }
    }
}
