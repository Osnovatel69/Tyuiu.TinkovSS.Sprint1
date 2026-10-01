using System;
using Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib;
using Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task20.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тиньков С.С.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x);

            Console.WriteLine($"Результат: {result}");

            Console.ReadLine();
        }
    }
}