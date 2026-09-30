using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task1.V13.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double result = dataService.Calculate(10);

            Assert.AreEqual(16.09344, result, 0.00001);
        }
    }
}
