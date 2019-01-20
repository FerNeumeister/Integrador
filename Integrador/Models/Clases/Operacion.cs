﻿using Integrador.Models.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Integrador.Models.Clases
{
    public class Operacion
    {
        public int Id { get; set; }
        public virtual Dispositivo Dispositivo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public virtual LogType LogType { get; set; }
    }
}