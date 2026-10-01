using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.V2.Lib;
namespace Tyuiu.TinkovSS.Sprint1.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

           
        double fahrenheit = 32;

            int wait = 0;
            int res = ds.Calculate(fahrenheit);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double fahrenheit = 212;

            int wait = 100;
            int res = ds.Calculate(fahrenheit);

            Assert.AreEqual(wait, res);
        }
    }
}