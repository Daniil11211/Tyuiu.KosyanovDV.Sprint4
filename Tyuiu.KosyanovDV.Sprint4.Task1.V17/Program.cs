using Tyuiu.KosyanovDV.Sprint4.Task1.V17.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                   *");
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #17                                                   *");
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
                Console.Write($"* Введите  {i} элемент массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            var res = ds.Calculate(array);
            Console.WriteLine($"* {res}                                                          *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}