
using Tyuiu.DyuvenzhiMI.Sprint4.Task3.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[,] m1 = new int[,] {
                { 5, 4, 9, 8, 5 },
                { 4, 6, 6, 9, 9 },
                { 9, 8, 4, 8, 8 },
                { 6, 8, 6, 8, 9 },
                { 9, 4, 6, 6, 7 } };

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(m1);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}