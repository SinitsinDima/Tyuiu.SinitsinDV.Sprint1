using Tyuiu.SinitsinDV.Sprint1.Task6.V16.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            string str = "Привет! как дела?";
            bool res = ds.CheckSpecSymbols(str);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}