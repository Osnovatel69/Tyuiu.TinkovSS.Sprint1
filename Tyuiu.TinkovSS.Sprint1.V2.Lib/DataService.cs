namespace Tyuiu.TinkovSS.Sprint1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
        Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Арифметические операции                                           *");
            Console.WriteLine("* Вариант №2                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            int celsius = ds.Calculate(fahrenheit);

            Console.WriteLine("Температура в градусах Цельсия: " + celsius);

            Console.ReadKey();
        }
    }
}