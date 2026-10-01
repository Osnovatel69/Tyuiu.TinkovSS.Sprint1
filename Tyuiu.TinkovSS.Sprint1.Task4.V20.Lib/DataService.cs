using System;

namespace Tyuiu.TinkovSS.Sprint1.Task4.V20.Lib
{
    public interface ISprint1Task4V20
    {
        double Calculate(double x);
    }

    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x)
        {
            double y = 0;
            double yPrev;
            double eps = 0.000001;
            int maxIter = 1000;

            for (int i = 0; i < maxIter; i++)
            {
                yPrev = y;
                y = (1 + x) / Math.Abs(x - Math.Sqrt(2) + yPrev);

                if (Math.Abs(y - yPrev) < eps)
                    break;
            }

            return Math.Round(y, 3);
        }
    }
}