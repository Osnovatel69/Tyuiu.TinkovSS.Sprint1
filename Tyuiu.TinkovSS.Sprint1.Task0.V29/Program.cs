using System;
using Tyuiu.TinkovSS.Sprint1.Task0.V29.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет выражение:");
            Console.WriteLine("2 * 9 + 7 * 2");

            DataService dataService = new DataService();

            int result = dataService.Calculate();

            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}