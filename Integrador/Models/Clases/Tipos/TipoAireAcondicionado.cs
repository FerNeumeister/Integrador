﻿using Integrador.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Models.Clases.Tipos
{
    class TipoAireAcondicionado : TipoDispositivo
    {
        private int temperatura;

        public override void BajarTemperatura()
        {
            // funcionalidad
            temperatura += 1;
        }

        public override void BajarIntensidad()
        {
        }

    }
}