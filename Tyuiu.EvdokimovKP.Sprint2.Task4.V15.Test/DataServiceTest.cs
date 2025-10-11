using Tyuiu.EvdokimovKP.Sprint2.Task4.V15.Lib;

namespace Tyuiu.EvdokimovKP.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 400;
            double res = ds.Calculate(x, y);
            double wait = 81.001;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 484;
            double res = ds.Calculate(x, y);
            double wait = 1.731;
            Assert.AreEqual(wait, res);
        }
    }
}
