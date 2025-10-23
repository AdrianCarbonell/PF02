using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02;

namespace Pruebas
{
    [TestClass]
    public class Test2
    {
        
        [TestMethod]
        public void Contrasenya_Null_DeberiaRetornarFalse()
        {
            bool resultado = Proyecto.EsContrasenyaValida(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_Vacia_DeberiaRetornarFalse()
        {
            bool resultado = Proyecto.EsContrasenyaValida("");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_MuyCorta_DeberiaRetornarFalse()
        {
            bool resultado = Proyecto.EsContrasenyaValida("abc#12");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_SinAlmohadilla_DeberiaRetornarFalse()
        {
            bool resultado = Proyecto.EsContrasenyaValida("password123");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_Valida_DeberiaRetornarTrue()
        {
            bool resultado = Proyecto.EsContrasenyaValida("abc#12345");
            Assert.IsTrue(resultado);
        }
    }

}