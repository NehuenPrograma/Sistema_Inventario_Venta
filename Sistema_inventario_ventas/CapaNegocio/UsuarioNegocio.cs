﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private CD_Usuario usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return usuario.Listar();
        }
        public bool UsuarioExiste(string documento)
        {
            CD_Usuario datos = new CD_Usuario();
            return datos.UsuarioExiste(documento);
        }

    }
}
