using Tyuiu.TinkovSS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double distance = 67;
            double consumption = 8.5;
            double price = 6.5;

            double wait = 74.035;
            double res = ds.Calculate(distance, consumption, price);

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}