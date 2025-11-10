
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int[] m1 = array;
            int i;
            int p = 1;
            for (i = 0; i <= m1.Length - 1; i++)
            {
                if (m1[i] % 2 != 0)
                {
                    p *= m1[i];
                }
            }
            return p;
        }
    }
}
