﻿using Integrador.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Models.Clases.Acciones
{
    public class AccionBajarTemperatura : IAccion
    {
        public void Accionar(DispositivoInteligente dispositivo)
        {
            dispositivo.TipoDispositivo.BajarTemperatura();
        }
    }
}