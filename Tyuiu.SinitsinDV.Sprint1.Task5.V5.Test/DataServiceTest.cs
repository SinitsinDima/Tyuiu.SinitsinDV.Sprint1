using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            DataService ds = new DataService();
            int d = 5;
            var x = 32.597;
            int y = GetFirstFractionDigit(x);
            IFormatProvider formatter = new NumberFormatInfo {NumberDecimalSeparator = "." };
            var res = ds.Calculate(x);
            double con = Convert.ToInt32(res);
        }
    }
}