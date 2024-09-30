using System.Globalization;
using Tyuiu.SinitsinDV.Sprint1.Task5.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            DataService ds = new DataService();
            double x = 32.597;
            int d = 5;
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(d, res);


        }
    }
 }