using Tyuiu.SinitsinDV.Sprint1.Task4.V11.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5;
            double b = 5;
            var res = ds.Calculate(a, b);
            var res2 = Math.Round(res, 3);
        }
    }
}