﻿using System;

namespace Servidor.OKCasa.Models
{
    public class Solicitud
    {
        public int Id_solicitud { get; set; }
        public String Direccion { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime? Fin { get; set; }
        public int Id_estado { get; set; }
        public int Id_servicio { get; set; }
        public int Id_equipo { get; set; }
        public String Rut { get; set; }
    }
}
