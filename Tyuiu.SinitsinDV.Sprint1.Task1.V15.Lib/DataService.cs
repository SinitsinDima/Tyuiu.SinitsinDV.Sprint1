using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SinitsinDV.Sprint1.Task1.V15.Lib
{
    public class DataService : ISprint1Task1V15
    {
        public double Calculate(double x)
        {
            return Math.Round((4 + 2 * x) / 7, 2);
        }
    }
}
