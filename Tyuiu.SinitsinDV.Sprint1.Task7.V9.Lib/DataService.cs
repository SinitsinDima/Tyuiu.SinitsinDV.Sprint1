using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SinitsinDV.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Exp(x) - ((Math.Pow(y, 2) + Math.Cos(x * x * x) + 12 * x * y - 3 * Math.Pow(x, 2)) / (Math.Cos(x * x * x + 3) + 18 * y - 1));
            double result = Math.Round(z, 3);
            return result;
        }
    }
}
