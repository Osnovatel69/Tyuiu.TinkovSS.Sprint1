using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            double numerator = 1 + x;
            double denominator = Math.Abs(x - Math.Sqrt(2 + y));

            double res = numerator / denominator;

            return Math.Round(res, 3);
        }
    }
}