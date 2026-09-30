using System;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V6.Lib
{
    public interface ISprint1Task4V6
    {
        double Calculate(double distance, double consumption, double price);
    }

    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double distance, double consumption, double price)
        {
            double totalDistance = distance * 2;
            double totalFuel = (totalDistance / 100) * consumption;
            double totalCost = totalFuel * price;
            return Math.Round(totalCost, 3);
        }
    }
}