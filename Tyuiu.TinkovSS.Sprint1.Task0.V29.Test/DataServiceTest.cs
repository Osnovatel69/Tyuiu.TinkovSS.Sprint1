using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task0.V29.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double result = dataService.Calculate();

            Assert.AreEqual(32, result);
        }
    }
}