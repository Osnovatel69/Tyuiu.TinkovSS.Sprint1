using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            // Числитель дроби: 2 + cos^2(x + y)
            double numerator = 2 + Math.Pow(Math.Cos(x + y), 2);

            // Знаменатель дроби: 1 + |x - (3x / (1 + x^2 * y^2))|
            double denominator = 1 + Math.Abs(x - (3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));

            // Итоговый результат с добавлением x * y и округлением до 3 знаков
            double result = (numerator / denominator) + (x * y);

            return Math.Round(result, 3);
        }
    }
}