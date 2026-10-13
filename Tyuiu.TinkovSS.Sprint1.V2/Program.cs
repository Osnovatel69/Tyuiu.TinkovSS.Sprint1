using System;
using Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Тиньков С.С. | Вариант 2";

            DataService ds = new DataService();

            Console.WriteLine("**************************************************");
            Console.WriteLine("* Спринт #1                                      *");
            Console.WriteLine("* Тема: Работа с математическими операциями      *");
            Console.WriteLine("* Задание #5                                     *");
            Console.WriteLine("* Вариант #2                                     *");
            Console.WriteLine("* Выполнил: Тиньков С.С.                         *");
            Console.WriteLine("**************************************************");
            Console.WriteLine();

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            int celsius = ds.ConvertFahrenheitToCelsius(fahrenheit);

            Console.WriteLine("Температура в градусах Цельсия: " + celsius);

            Console.ReadKey();
        }
    }

}