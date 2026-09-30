using System;
using Tyuiu.TinkovSS.Sprint1.Task2.V13.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в милях:");

            int miles = Convert.ToInt32(Console.ReadLine());

            DataService dataService = new DataService();

            double result = dataService.Calculate(miles);

            Console.WriteLine("Расстояние в километрах: " + result.ToString("0.000"));

            Console.ReadKey();
        }
    }
}
