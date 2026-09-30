using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task1.V30.Lib
{
    public class DataService : ISprint1Task1V30
    {
        public double Calculate(double x)
        {
            return (2.0 + x) / 2.0;
        }

        public double Calculate()
        {
            throw new NotImplementedException();
        }
    }
}