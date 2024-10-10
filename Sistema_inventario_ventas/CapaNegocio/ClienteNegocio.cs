using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ClienteNegocio
    {
        private CD_Cliente cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return cliente.Listar();
        }
    }
}
