using Tyuiu.SinitsinDV.Sprint1.Task2.V15.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            
            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Арифметические операторы в C#                     *");
            Console.WriteLine("* Задание #2                                        *");
            Console.WriteLine("* Вариант #15                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Известна длина стороны куба. Вычислить            *");
            Console.WriteLine("* объем куба                                        *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Введите значение x:                               *");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Объём куба X - " + ds.CalculateCubeVolume(x));                            

        }
    }
}
