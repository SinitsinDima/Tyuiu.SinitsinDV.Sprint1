using System.Globalization;
using Tyuiu.SinitsinDV.Sprint1.Task5.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert        *");
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #5                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из      *");
            Console.WriteLine("* дробной части положительного вещественного числа  *");
            Console.WriteLine("* x (так, если x=32.597, то d=5).                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
