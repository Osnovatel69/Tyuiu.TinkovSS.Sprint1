using System;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib
{
    public class DataService
    {
        public int ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return Convert.ToInt32(celsius);
        }
    }
}