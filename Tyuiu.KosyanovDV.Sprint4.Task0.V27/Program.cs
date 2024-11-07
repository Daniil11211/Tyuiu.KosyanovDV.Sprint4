using Tyuiu.KosyanovDV.Sprint4.Task0.V27.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task0.V27
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
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #27                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив чисел. Найти произведение нечётных элементов       *");
            Console.WriteLine("* массива                                                       *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* МАССИВ:                                                       *");
            Console.WriteLine("*                                                               *");
            int[] array = new int[] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.Write("* ");

            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine("4                                  *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            var res = ds.GetMultOddArrEl(array);
            Console.WriteLine($"* {res}                                                          *");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}