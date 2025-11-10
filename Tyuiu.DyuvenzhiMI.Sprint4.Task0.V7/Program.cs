
using Tyuiu.DyuvenzhiMI.Sprint4.Task0.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[] m1 = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
        int res = ds.GetMultOddArrEl(m1);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Ответ: " + res);
        Console.ReadLine();
    }
}