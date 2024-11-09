using Tyuiu.KosyanovDV.Sprint4.Task5.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task5.V1
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
            Console.WriteLine("* Вариант #1                                                    *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив чисел, заполненный числами в диапазоне от -9 до 8. *");
            Console.WriteLine("* Заменить положительные числа на 1                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* МАССИВ:                                                       *");
            Console.WriteLine("*                                                               *");

            int str;
            Console.Write("* Введите количество строк: ");
            str = Convert.ToInt32(Console.ReadLine());

            int col;
            Console.Write("* Введите количество столбцов: ");
            col = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[str, col];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-9, 9);
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int[,] res = ds.Calculate(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}