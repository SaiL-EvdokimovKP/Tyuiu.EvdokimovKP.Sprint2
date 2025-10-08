using Tyuiu.EvdokimovKP.Sprint2.Task2.V15.Lib;

namespace Tyuiu.EvdokimovKP.Sprint2.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
