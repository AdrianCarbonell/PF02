using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02;

namespace Pruebas
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CalcularFactorial_Negativo_DeberiaRetornar_MenosUno()
        {
            long resultado = Proyecto.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DeberiaRetornar_Uno()
        {
            long resultado = Proyecto.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Uno_DeberiaRetornar_Uno()
        {
            long resultado = Proyecto.CalcularFactorial(1);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Tres_DeberiaRetornar_Seis()
        {
            long resultado = Proyecto.CalcularFactorial(3);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DeberiaRetornar_CientoVeinte()
        {
            long resultado = Proyecto.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Diez_DeberiaRetornar_3628800()
        {
            long resultado = Proyecto.CalcularFactorial(10);
            Assert.AreEqual(3628800, resultado);
        }
    }
}
