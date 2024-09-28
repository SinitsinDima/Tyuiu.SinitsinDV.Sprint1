using Tyuiu.SinitsinDV.Sprint1.Task3.V19.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidWExpression()
        {
            DataService ds = new DataService();
            double x1 = 3;
            double x2 = 5;
            double y1 = 2;
            double y2 = 3;
            bool res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(true, res);
        }
    }
}