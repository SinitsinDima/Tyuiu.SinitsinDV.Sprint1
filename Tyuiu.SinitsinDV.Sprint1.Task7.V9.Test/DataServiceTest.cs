using Tyuiu.SinitsinDV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            var wait = 2.073;
            Assert.AreEqual(wait, res);
        }
    }
}