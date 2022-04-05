using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoradeImpuestosTest 
{ 

    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            CalculadoradeImpuestos ci = new CalculadoradeImpuestos();

            decimal iva = ci.ObtenerIVA(1550.00m);

            Assert.AreEqual(294.5m, iva);
        }

        [TestMethod]
        public void ISHTest()
        {
            CalculadoradeImpuestos ci = new CalculadoradeImpuestos();

            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            Assert.AreEqual(46.5m, ish);
        }

        [TestMethod]
        public void MTR()
        {
            CalculadoradeImpuestos ci = new CalculadoradeImpuestos();

            decimal mtr = ci.ObtenerMontoTotal(1550.00m, 5);

            Assert.AreEqual(155000000m, mtr);
        }
    }
}
