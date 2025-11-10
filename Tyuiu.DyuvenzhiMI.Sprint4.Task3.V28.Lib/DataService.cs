
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int[,] m = array;
            int min = 1000000;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (j == 3)
                    {
                        min = int.Min(min, m[i, j]);
                    }
                }
            }
            return min;
        }
    }
}
