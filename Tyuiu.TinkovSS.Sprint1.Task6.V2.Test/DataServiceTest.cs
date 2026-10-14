using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckHello()
        {
            DataService ds = new DataService();
            string str = "Hello world!";
            bool res = ds.CheckHello(str);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void InvalidCheckHello()
        {
            DataService ds = new DataService();
            string str = "Good morning!";
            bool res = ds.CheckHello(str);
            Assert.AreEqual(false, res);
        }
    }
}