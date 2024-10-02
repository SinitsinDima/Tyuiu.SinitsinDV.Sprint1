using tyuiu.cources.programming.interfaces.Sprint1; 
namespace Tyuiu.SinitsinDV.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {

            bool res;
            
            if (value.Contains('!') | value.Contains('?'))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
