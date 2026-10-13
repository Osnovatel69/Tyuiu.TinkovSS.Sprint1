using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        [TestMethod]
        public void ConvertFahrenheitToCelsius_32F_Returns0C()
        {
            int result = ds.ConvertFahrenheitToCelsius(32);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelsius_212F_Returns100C()
        {
            int result = ds.ConvertFahrenheitToCelsius(212);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ConvertFahrenheitToCelsius_68F_Returns20C()
        {
            int result = ds.ConvertFahrenheitToCelsius(68);
            Assert.AreEqual(20, result);
        }
    }

}