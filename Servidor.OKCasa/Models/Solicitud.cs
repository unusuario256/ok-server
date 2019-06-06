﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servidor.OKCasa.Models
{
    public class Solicitud
    {
        [Key]
        public int Id_solicitud { get; set; }
        public String Direccion { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime? Fin { get; set; }
        public String Usuario { get; set; }
        public int Id_estado { get; set; }
        public int Id_servicio { get; set; }
        public int Id_equipo { get; set; }
    }
}
