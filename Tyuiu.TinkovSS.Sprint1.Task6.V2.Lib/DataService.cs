using System;

namespace Tyuiu.TinkovSS.Sprint1.Task6.V2.Lib
{
    public interface ISprint1Task6V2
    {
        bool Calculate(string text);
    }

    public class DataService : ISprint1Task6V2
    {
        public bool Calculate(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            return text.Contains("Hello");
        }
    }
}