using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoradeImpuestosTest

    /* 
        ** Obtener el IVA a partir del monto de una reserva. 19%
        ** Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
        *  Obtener el monto total de la reserva (con impuestos incluidos)
     */
{
    [TestClass]
    public class CalculadoraTest
    {
        //Test Obtener el IVA a partir del monto de una reserva. 19%
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange
            CalculadoradeImpuestos ci = new CalculadoradeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //Assert
            // iva = 19%
            // monto reserva = 1550
            //1550.00 * .19 = 294.5
            Assert.AreEqual(294.5m, iva);
        }


        // Test Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
        [TestMethod]
        public void ISHTest()
        {
            //Arrange
            CalculadoradeImpuestos ci = new CalculadoradeImpuestos();

            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            // ish = 3%
            // monto reserva = 1550
            //1550.00 * .03 = 46.5
            Assert.AreEqual(46.5m, ish);
        }
    }
}
