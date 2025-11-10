
using Tyuiu.DyuvenzhiMI.Sprint4.Task2.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        Random rnd = new Random();
        int len = 15;
        int[] m1 = new int[len];
        for (int i = 0; i < m1.Length; i++)
        {
            m1[i] = rnd.Next(1,7);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(m1);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}