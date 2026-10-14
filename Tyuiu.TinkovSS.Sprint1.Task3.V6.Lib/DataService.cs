using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasAmount, double priceGas)
        {
            // Поездка туда и обратно (2 * distance)
            double result = 2 * distance * (gasAmount / 100.0) * priceGas;

            return Math.Round(result, 3);
        }
    }
}