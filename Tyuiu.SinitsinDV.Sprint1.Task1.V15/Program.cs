using Tyuiu.SinitsinDV.Sprint1.Task1.V15.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Организация ввода\\вывода                   *");
            Console.WriteLine("* в консольных приложениях                          *");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #15                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает           *");
            Console.WriteLine("* у пользователя исходные данные, вычисляет результат");
            Console.WriteLine("* по формуле (4+2*x)/7 и печатает его на экране.    *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            
            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
