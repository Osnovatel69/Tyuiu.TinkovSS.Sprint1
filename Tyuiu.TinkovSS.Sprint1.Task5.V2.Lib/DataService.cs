using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int ConvertFahrenheitToCelsius(int fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            return Convert.ToInt32(celsius);
        }

        public int FahrenheitToСelsius(double temp)
        {
            throw new NotImplementedException();
        }
    }
}