
using Tyuiu.DyuvenzhiMI.Sprint4.Task2.V21.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m1 = new int[] { 1,2,3,4,5 };
            int res = ds.Calculate(m1);
            Assert.AreEqual(8, res);
        }
    }
}
