using Tyuiu.SinitsinDV.Sprint1.Task6.V16.Lib;
namespace Tyuiu.SinitsinDV.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Работа со строками класс String             *");
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #16                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.    *");
            Console.WriteLine("* Проверить, что в строке есть восклицание (!)      *");
            Console.WriteLine("* и вопрос (?).                                     *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            string str = Console.ReadLine();
            

            
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine(ds.CheckSpecSymbols(str));
        }
    }
}
