using Tyuiu.SinitsinDV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых               *");
            Console.WriteLine("* проектов по спринту                               *");
            Console.WriteLine("* Задание #7                                        *");
            Console.WriteLine("* Вариант #9                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет             *");
            Console.WriteLine("* математическое выражение по исходным значениям    *");
            Console.WriteLine("* данных, вводимых пользователем.                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Введите x: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите y: ");
            string str2 = Console.ReadLine();
            double x = Convert.ToInt32(str1);
            double y = Convert.ToInt32(str2);

            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            double z = Math.Exp(x) - ((Math.Pow(y, 2) + Math.Cos(x * x * x) + 12 * x * y - 3 * Math.Pow(x, 2)) / (Math.Cos(x * x * x + 3) + 18 * y - 1));
            Console.WriteLine($"{Math.Round(z, 3)}");
        }
    }
}
