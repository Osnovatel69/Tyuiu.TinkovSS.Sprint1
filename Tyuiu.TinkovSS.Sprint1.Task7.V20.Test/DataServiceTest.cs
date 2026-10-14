using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task7.V20.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;

            // Расчет для x = 1, y = 2:
            // cos(3) ≈ -0.98999 -> cos^2(3) ≈ 0.98008 -> числитель = 2.98008
            // знаменатель = 1 + |1 - 3/5| = 1 + 0.4 = 1.4
            // 2.98008 / 1.4 ≈ 2.1286 + 2 = 4.129
            double wait = 4.129;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}