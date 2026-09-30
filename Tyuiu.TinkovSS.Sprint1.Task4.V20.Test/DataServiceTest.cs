using Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public object Assert { get; private set; }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 2;
            double wait = 2.088;
            double res = ds.Calculate(x);
            _ = Assert.AreEqual(wait, res);
        }
    }
}