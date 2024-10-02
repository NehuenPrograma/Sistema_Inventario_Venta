using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [DisplayName("Nº Documento")]
        public string Documento { get; set; }

        [DisplayName("Nombre y Apellido")]
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }

        [DisplayName("Contraseña")]
        public string Clave { get; set; }

        // oRol == objeto Rol
        [DisplayName("Rol")]
        public Rol oRol { get; set; }

        public int IdRol { get; set; }
        public string FechaRegistro { get; set; }
    }
}
