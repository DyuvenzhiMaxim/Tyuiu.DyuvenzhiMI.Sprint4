
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyuvenzhiMI.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] res = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    res[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    /*for (int k = 0; k < res.Length; k++)
                    {
                        Console.Write(res[i, j] + " ");
                    }*/
                }
            }

            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (res[i,j] % 2 == 0)
                    {
                        p *= res[i, j];
                    }
                }
            }
            return p;
        }
    }
}
