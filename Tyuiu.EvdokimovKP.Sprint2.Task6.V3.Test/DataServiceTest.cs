using Tyuiu.EvdokimovKP.Sprint2.Task6.V3.Lib;

namespace Tyuiu.EvdokimovKP.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("ïîíåäåëüíèê", ds.FindDayName(1));
            Assert.AreEqual("âòîðíèê", ds.FindDayName(2));
            Assert.AreEqual("ñðåäà", ds.FindDayName(3));
            Assert.AreEqual("÷åòâåðã", ds.FindDayName(4));
            Assert.AreEqual("ïÿòíèöà", ds.FindDayName(5));
            Assert.AreEqual("ñóááîòà", ds.FindDayName(6));
            Assert.AreEqual("âîñêðåñåíüå", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}
