using System;
using TPBolillero;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebaBolillero
{
    [TestClass]
    public class UnitTest1
    {
        byte cantBolillas;
        Bolillero bolillero;

        [TestInitialize]
        public void iniciar()
        {
            cantBolillas = 100;
            bolillero = new Bolillero(cantBolillas);
        }

        [TestMethod]
        public void cantidadDeBolillas()
        {
            Assert.AreEqual(cantBolillas, bolillero.BolillasAdentro.Count);
            Assert.AreEqual(0, bolillero.BolillasFuera.Count);
        }

        [TestMethod]
        public void efectoDelBolillero()
        {
            byte bolilla = bolillero.sacarBolillaAlAzar();
            Assert.IsFalse(bolillero.BolillasAdentro.Contains(bolilla));
            Assert.IsTrue(bolillero.BolillasFuera.Contains(bolilla));
        }

        [TestMethod]
        public void probandoClon()
        {
            Bolillero otroBolillero = (Bolillero)bolillero.Clone();
            Assert.AreEqual(otroBolillero.CantidadDeBolillas, bolillero.CantidadDeBolillas);
            Assert.AreEqual(otroBolillero.BolillasAdentro.Count, bolillero.BolillasAdentro.Count);
            Assert.IsTrue(otroBolillero.BolillasAdentro.TrueForAll(bolilla => bolillero.BolillasAdentro.Contains(bolilla)));
            Assert.AreNotSame(bolillero, otroBolillero);
            Assert.AreSame(bolillero, bolillero);
        }
        [TestMethod]

        public void vecesQueAcierta()
        {
            List<Byte> listita = new List<Byte>{0};
            Bolillero unBolillero = new Bolillero(1);
            Assert.AreEqual((ulong)500000000, Simulacion.VecesQueAcierta(unBolillero, listita, 500000000));
                
        }

    }
}
