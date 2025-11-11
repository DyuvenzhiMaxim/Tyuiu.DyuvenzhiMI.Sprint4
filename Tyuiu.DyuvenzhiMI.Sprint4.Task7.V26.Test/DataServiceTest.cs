
using Tyuiu.DyuvenzhiMI.Sprint4.Task7.V26.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int w = 5;
            int h = 3;
            int[,] mat = new int[w, h];
            string str = "351268459614723";
            DataService ds = new DataService();
            int res = ds.Calculate(w,h,str);
            int wait = 18432;
            Assert.AreEqual(wait, res);
        }
    }
}
