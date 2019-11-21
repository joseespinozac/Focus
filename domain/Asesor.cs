﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.domain
{
    class Asesor
    {
        private string noPersonal;
        private string rol;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string usuario;
        private string password;

        public string NoPersonal { get => noPersonal; set => noPersonal = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
