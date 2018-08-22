﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using Integrador.Models;
using Integrador.Models.Clases.Tipos;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Integrador.Services
{
    public class DeviceService
    {
        public double findConsumo(string NombreDispositivo)
        {
            var json = "{\"De 3500 frigorás\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":false,\"Consumo\":1.613}," +
                       "\"De 2200 frigorás\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":1.013}," +
                       "\"Color de tubo fluorescente de 21\":{ \"EsInteligente\":false,\"EsDeBajoConsumo\":false,\"Consumo\":0.075}," +
                       "\"Color de tubo fluorescente de 29 a 34\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":false,\"Consumo\":0.175}," +
                       "\"LCD de 40\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":false,\"Consumo\":0.18}," +
                       "\"LED de 24\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.04}," +
                       "\"LED de 32\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.055}," +
                       "\"LED de 40\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.08}," +
                       "\"Con freezer\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.09}," +
                       "\"Sin freezer\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.075}," +
                        "\"Automático de 5 kg con calentamiento de agua\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":false,\"Consumo\":0.875}," +
                        "\"Automático de 5 kg\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.175}," +
                        "\"Semi-Automático de 5 kg\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":true,\"Consumo\":0.1275}," +
                        "\"De pie\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":true,\"Consumo\":0.09}," +
                        "\"De techo\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.06}," +
                        "\"Halógenas de 40 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":false,\"Consumo\":0.04}," +
                        "\"Halógenas de 60 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":false,\"Consumo\":0.06}," +
                        "\"Halógenas de 100 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":false,\"Consumo\":0.015}," +
                        "\"De 11 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.011}," +
                        "\"De 15 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.015}," +
                        "\"De 20 W\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.02}," +
                        "\"De escritorio\":{\"EsInteligente\":true,\"EsDeBajoConsumo\":true,\"Consumo\":0.4}," +
                        "\"Convencional\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":true,\"Consumo\":0.64}," +
                        "\"A vapor\":{\"EsInteligente\":false,\"EsDeBajoConsumo\":true,\"Consumo\":0.75}}";
            var data = (JObject)JsonConvert.DeserializeObject<object>(json);
            double consumo = Convert.ToDouble(data[NombreDispositivo]["Consumo"]);
            return consumo;

        }
    }
}