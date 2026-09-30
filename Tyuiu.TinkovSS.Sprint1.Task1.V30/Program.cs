using System;
using Tyuiu.TinkovSS.Sprint1.Task0.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");

            double x = Convert.ToDouble(Console.ReadLine());

            DataService dataService = new DataService();

            double result = dataService.Calculate(x);

            Console.WriteLine("Результат: " + result.ToString("0.0"));

            Console.ReadKey();
        }
    }
}