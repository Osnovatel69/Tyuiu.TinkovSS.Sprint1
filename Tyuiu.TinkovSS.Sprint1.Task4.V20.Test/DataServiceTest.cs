using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double wait = 2;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}