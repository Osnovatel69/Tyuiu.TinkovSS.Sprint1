using System;
using Tyuiu.TinkovSS.Sprint1.V2.Lib;
namespace Tyuiu.TinkovSS.Sprint1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            C#
        Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Арифметические операции                                           *");
            Console.WriteLine("* Вариант №2                                                              *");
            Console.WriteLine("* Задание: Дано значение температуры в градусах Фаренгейта.               *");
            Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            int celsius = ds.Calculate(fahrenheit);

            Console.WriteLine("Температура в градусах Цельсия: " + celsius);

            Console.ReadKey();
        }
    }
}