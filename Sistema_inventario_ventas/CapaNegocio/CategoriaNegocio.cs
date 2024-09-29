using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CategoriaNegocio
    {
        private CD_Categoria categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return categoria.Listar();
        }
    }
}
