
using Tyuiu.DyuvenzhiMI.Sprint4.Task3.V28.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] m1 = new int[,] {
                { 5, 4, 9, 8, 5 },
                { 4, 6, 6, 9, 9 },
                { 9, 8, 4, 8, 8 },
                { 6, 8, 6, 8, 9 },
                { 9, 4, 6, 6, 7 } };
            int res = ds.Calculate(m1);
            Assert.AreEqual(6, res);

        }
    }
}
