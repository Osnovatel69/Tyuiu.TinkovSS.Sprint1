using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertFahrenheitToCelsius_212_Returns100()
        {
            DataService dataService = new DataService();

            int fahrenheit = 212;
            int expected = 100;

            int actual = dataService.ConvertFahrenheitToCelsius(fahrenheit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidConvertFahrenheitToCelsius_32_Returns0()
        {
            DataService dataService = new DataService();

            int fahrenheit = 32;
            int expected = 0;

            int actual = dataService.ConvertFahrenheitToCelsius(fahrenheit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidConvertFahrenheitToCelsius_Minus40_ReturnsMinus40()
        {
            DataService dataService = new DataService();

            int fahrenheit = -40;
            int expected = -40;

            int actual = dataService.ConvertFahrenheitToCelsius(fahrenheit);

            Assert.AreEqual(expected, actual);
        }
    }
}