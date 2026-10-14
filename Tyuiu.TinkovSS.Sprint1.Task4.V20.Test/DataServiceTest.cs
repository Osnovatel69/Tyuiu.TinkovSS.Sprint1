using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 2; // sqrt(2 + 2) = 2, знаменатель: |4 - 2| = 2, числитель: 1 + 4 = 5 -> 5 / 2 = 2.5

            double res = ds.Calculate(x, y);
            double wait = 2.5;

            Assert.AreEqual(wait, res);
        }
    }
}