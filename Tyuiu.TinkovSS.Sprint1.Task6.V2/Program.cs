using Tyuiu.TinkovSS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.TinkovSS.Sprint1.Task6.V2
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

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.Calculate(text);

            if (result)
            {
                Console.WriteLine("Слово \"Hello\" найдено в строке.");
            }
            else
            {
                Console.WriteLine("Слово \"Hello\" НЕ найдено в строке.");
            }

            Console.ReadLine();
        }
    }
}