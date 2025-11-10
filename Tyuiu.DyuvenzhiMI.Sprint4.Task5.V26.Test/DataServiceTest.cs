
using Tyuiu.DyuvenzhiMI.Sprint4.Task5.V26.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] m = new int[,] {
                { -3, -2, -1, 0, 1, 2, 3, 4 },
                { -3, -2, -1, 0, 1, 2, 3, 4 } };

            int[,] res = ds.Calculate(m);

            int[,] wait = new int[,] {
                { -3, -2, -1, 0, 1, 1, 1, 1 },
                { -3, -2, -1, 0, 1, 1, 1, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
