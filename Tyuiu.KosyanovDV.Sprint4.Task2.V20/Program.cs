using Tyuiu.KosyanovDV.Sprint4.Task2.V20.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task2.V20
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
            Console.WriteLine("* Тема: Одномерные массивы (Генератор случайных чисел)          *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #20                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив чисел. Найти сумму чётных элементов массива        *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* МАССИВ:                                                       *");
            Console.WriteLine("*                                                               *");
            Console.Write("* Введите количество элементов массива: ");
            int len;
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(2, 8);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            var res = ds.Calculate(array);
            Console.WriteLine($"* {res}                                                          ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}