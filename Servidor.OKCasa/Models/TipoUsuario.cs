﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servidor.OKCasa.Models
{
    public class TipoUsuario
    {
        [Key]
        public int Id_tipo { get; set; }
        public String Nombre { get; set; }
    }
}
