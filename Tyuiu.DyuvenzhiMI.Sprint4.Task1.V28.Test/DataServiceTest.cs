
using Tyuiu.DyuvenzhiMI.Sprint4.Task1.V28.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m1 = new int[] { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(m1);
            Assert.AreEqual(375, res);
        }
    }
}
