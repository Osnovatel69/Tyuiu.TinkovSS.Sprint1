using Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Task5 | Вариант 2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Ввод и вывод данных                                                *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Тиньков С.С.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService dataService = new DataService();

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            int celsius = dataService.ConvertFahrenheitToCelsius(fahrenheit);

            Console.WriteLine();
            Console.WriteLine($"Температура в градусах Цельсия: {celsius}");

            Console.ReadKey();
        }
    }
}