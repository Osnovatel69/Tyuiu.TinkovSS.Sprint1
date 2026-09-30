using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task1.V13.Lib
{
    public class DataService : ISprint1Task1V13
    {
        public double Calculate(int miles)
        {
            return Math.Round(miles * 1.609344, 3);
        }

        public double Calculate(double x)
        {
            throw new NotImplementedException();
        }
    }
}