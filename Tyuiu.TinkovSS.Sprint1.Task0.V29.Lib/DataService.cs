using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task0.V29.Lib
{
    public class DataService : ISprint1Task0V29
    {
        public int Calculate()
        {
            return 2 * 9 + 7 * 2;
        }

        double ISprint1Task0V29.Calculate()
        {
            return Calculate();
        }
    }
}