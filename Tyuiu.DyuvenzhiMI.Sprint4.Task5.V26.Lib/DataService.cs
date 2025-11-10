
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task5V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] m = matrix;
            //int[,] res = new int[2, 2];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > 0)
                    {
                        m[i, j] = 1;
                    }
                }
            }
            return m;
        }
    }
}
