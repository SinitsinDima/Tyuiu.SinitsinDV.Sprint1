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
            double x = 5;
            double y = 5;
            double wait = 0.010;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, res);
            
        }
    }
}