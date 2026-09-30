using Tyuiu.TinkovSS.Sprint1.Task1.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double result = dataService.Calculate(4.0);

            Assert.AreEqual(3.0, result);
        }
    }
}