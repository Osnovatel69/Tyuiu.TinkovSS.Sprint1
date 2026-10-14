using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task3.V6.Lib.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTravelCost()
        {
            DataService ds = new DataService();

            double distance = 67;
            double gasAmount = 8.5;
            double priceGas = 6.5;

            // Расчет: 2 * 67 * (8.5 / 100) * 6.5 = 134 * 0.085 * 6.5 = 74.035 -> 74.035
            double wait = 74.035;
            double res = ds.TravelCost(distance, gasAmount, priceGas);

            Assert.AreEqual(wait, res);
        }
    }
}