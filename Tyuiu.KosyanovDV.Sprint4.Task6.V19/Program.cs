using Tyuiu.KosyanovDV.Sprint4.Task6.V19.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (Генератор случайных чисел)           *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #19                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив строк. Используя класс Array, подсчитайте          *");
            Console.WriteLine("* количество элементов, длина которых больше 5                  *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* МАССИВ:                                                       *");
            Console.WriteLine("*                                                               *");

            string[] str = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]}, ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.Calculate(str)}                                                             *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}