using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class MediaTest
    {
        [TestMethod]
        public void TestMedia()
        {
            Media media = new Media();
            string[] valores = {"5", "2", "2"};
            double resultado = media.CalcularMedia(valores);
            double esperado = 3;
            Assert.AreEqual(esperado, resultado);
        }
    }
}