using Tyuiu.TinkovSS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string text = "Hello, World!";
            bool wait = true;
            bool res = ds.Calculate(text);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateNoHello()
        {
            DataService ds = new DataService();

            string text = "Goodbye, World!";
            bool wait = false;
            bool res = ds.Calculate(text);

            Assert.AreEqual(wait, res);
        }
    }
}