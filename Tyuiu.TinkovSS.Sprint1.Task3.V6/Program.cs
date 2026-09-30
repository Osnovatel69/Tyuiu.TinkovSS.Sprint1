using System;
using Tyuiu.TinkovSS.Sprint1.Task4.V6.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V6
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

            Console.WriteLine("Введите расстояние до дачи (км):");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расход бензина (литров на 100 км пробега):");
            double consumption = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите цену одного литра бензина (руб.):");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(distance, consumption, price);

            Console.WriteLine($"Поездка на дачу и обратно обойдется в {result} руб.");

            Console.ReadLine();
        }
    }
}