using Tyuiu.KosyanovDV.Sprint4.Task3.V21.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (Статический ввод)                    *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #21                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив чисел. Найти произведение последнего столбца       *");
            Console.WriteLine("* массива.                                                      *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* МАССИВ:                                                       *");
            Console.WriteLine("*                                                               *");

            int[,] array = { { 8, 3, 3, 3, 5 },
                             { 6, 7, 3, 3, 7 },
                             { 4, 5, 4, 6, 6 },
                             { 5, 5, 8, 8, 7 },
                             { 4, 6, 6, 7, 7 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine(" ");
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