using System;
using Tyuiu.TinkovSS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тиньков С. С. | Task3.V6";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | Task3.V6                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно). Ответ округлить до 3 знаков после запятой.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Расстояние до дачи (км) -> ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Расход бензина (литров на 100 км пробега) -> ");
            double gasAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Цена литра бензина (руб.) -> ");
            double priceGas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.TravelCost(distance, gasAmount, priceGas);

            Console.WriteLine($"Поездка на дачу и обратно обойдется в {result} руб.");

            Console.ReadKey();
        }
    }
}