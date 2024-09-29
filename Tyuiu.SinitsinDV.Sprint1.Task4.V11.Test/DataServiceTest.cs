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
            double x = Math.Atan(3);
            double y = Math.Pow(2, 3);
            double value = x / y;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(value, res);
        }
    }
}