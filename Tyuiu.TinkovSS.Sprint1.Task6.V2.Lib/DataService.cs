using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TinkovSS.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public DataService()
        {
        }

        public bool CheckHello(string value)
        {
            // Проверка наличия слова "Hello" в строке
            return value.Contains("Hello");
        }
    }
}