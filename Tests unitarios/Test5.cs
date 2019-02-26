using System;
using Integrador.DAL;
using Integrador.Models;
using Integrador.Models.Clases;
using Integrador.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests_unitarios
{
    [TestClass]
    public class Test5
    {
        private Context db = new Context();
        private ClienteService clienteService = new ClienteService();
        private DispositivoService dispositivoService = new DispositivoService();
        private TransformadorService transformadorService = new TransformadorService();

        private DateTime desde = DateTime.Today.AddDays(-360);
        private DateTime hasta = DateTime.Now;

        [TestMethod]
        public void CasoDePrueba5()
        {

                         //Dado un hogar y un periodo mostrar por consola el consumo total.
         
                        //cliente
                        Cliente cliente = new Cliente()
                        {
                            Nombre = "Juan",
                            Apellido = "Gonzalez",
                            TipoDoc = "DNI",
                            NroDoc = 12345678,
                            Latitud = -10.1000, //Coord Domic.
                            Longitud = -30.1000,
                            Domicilio = "Rivadavia 2888",
                            Transformador= new Transformador() { Nombre = "T1", Activo = true, EnergiaSuministrada = 402685, Latitud = -34.5550886, Longitud = -58.4879849}
                        };
                        //db.Clientes.Add(cliente);
                        //db.SaveChanges();

                        Console.WriteLine("Consumo Total Cliente: ", clienteService.ConsumoTotal(cliente, desde, hasta));

                        //Dado un dispositivo y un periodo

                        DispositivoInteligente dispositivo = new DispositivoInteligente()
                         {
                            NombreGenerico = "Smart 200",
                            Consumo = 0.15,
                            UsoMensualMax = 360,
                            UsoMensualMin = 30,
                            Encendido=true,
                            ModoAhorroDeEnergia=false,
                            Inteligente=true
                         };
                        
                        //Console.WriteLine("Consumo Total Dispositivo: ", dispositivoService.ConsumoDispositivo(desde, hasta,dispositivo));

                        //Dado un transformador y un periodo calcular su consumoTotal
                                   
                        ZonaGeografica zonaNoroeste = new ZonaGeografica()
                       {
                           Radio = 20500,
                           NombreZona = "Noroeste",
                           Latitud = -34.5550886,
                           Longitud = -58.4879849
                       };

                        Transformador transformador = new Transformador()
                        {
                            Nombre = "T1",
                            Activo = true,
                            EnergiaSuministrada = 402685,
                            Latitud = -34.5550886,
                            Longitud = -58.4879849,
                            ZonaGeografica = zonaNoroeste
                        };
                        //Console.WriteLine("Consumo Total Transformador: ",transformador.GetConsumoTotal() );


        }


    }

}
 

 
