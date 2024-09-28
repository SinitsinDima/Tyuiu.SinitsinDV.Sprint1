using Tyuiu.SinitsinDV.Sprint1.Task3.V19.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Операторы составного присваивания           *");
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #19                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает           *");
            Console.WriteLine("* у пользователя исходные данные, выполняет         *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране. *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            double x1 = 3;
            double x2 = 5;
            double y1 = 2;
            double y2 = 3;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение:" + ds.ElephCanMove(double x1, double x2, double y1, double y2);


        }
    }
}
