
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int[] m1 = array;
            int p = 1;
            for (int i = 0; i <= m1.Length - 1; i++)
            {
                if (m1[i] % 2 == 0)
                {
                    p *= m1[i];
                }
            }
            return p;
        }
    }
}
