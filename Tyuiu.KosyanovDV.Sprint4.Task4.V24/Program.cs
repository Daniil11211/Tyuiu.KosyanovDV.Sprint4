﻿using Tyuiu.KosyanovDV.Sprint4.Task4.V24.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (Ввод с клавиатуры)                   *");
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #24                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан массив чисел, введённых с клавиатуры. Заменить чётные     *");
            Console.WriteLine("* элементы массива на 1.                                        *");
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
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
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
            }
            Console.WriteLine(" ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}
