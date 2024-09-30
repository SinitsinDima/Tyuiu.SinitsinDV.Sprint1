using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionDigitExtractor;
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
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double d = 5;
            double x = double.Parse("32.597");
            var res = ds.Calculate(x);
            var wait = 53;
            Assert.AreEqual(wait, res);


        }
    }
 }