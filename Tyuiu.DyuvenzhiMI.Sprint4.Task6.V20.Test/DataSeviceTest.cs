
using Tyuiu.DyuvenzhiMI.Sprint4.Task6.V20.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task6.V20.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = ds.Calculate(mas);
            string[] wait = new string[] { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
