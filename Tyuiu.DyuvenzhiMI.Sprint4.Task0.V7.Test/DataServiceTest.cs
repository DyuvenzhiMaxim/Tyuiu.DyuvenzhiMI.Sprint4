
using Tyuiu.DyuvenzhiMI.Sprint4.Task0.V7.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m1 = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(m1);
            int wait = 178605;
            Assert.AreEqual(wait, res);
        }
    }
}
