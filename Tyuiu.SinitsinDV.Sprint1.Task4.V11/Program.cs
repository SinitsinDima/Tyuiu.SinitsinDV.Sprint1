using System.Threading.Channels;
using Tyuiu.SinitsinDV.Sprint1.Task4.V11.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Class Math                                  *");
            Console.WriteLine("* Задание #4                                        *");
            Console.WriteLine("* Вариант #11                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у         *"); 
            Console.WriteLine("* пользователя исходные данные, вычисляет           *");
            Console.WriteLine("* результат по формуле и печатает его на экране.    *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int x, e, y;


            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение e: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y ");
            y = Convert.ToInt32(Console.ReadLine());
            var res = Math.Atan(x) / Math.Pow(e, y);

            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine($" {Math.Round(res, 3)}");
        }
    }
}
