using Tyuiu.KosyanovDV.Sprint4.Task7.V17.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту       *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #17                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дана строка. Преобразовать данную строку в матрицу и          *");
            Console.WriteLine("* подсчитать количество чётных чисел                            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* СТРОКА:                                                       *");
            Console.WriteLine("*                                                               *");

            string value = "753159864";

            Console.WriteLine($"* {value}                                                     *");

            int str = 3;
            int col = 3;

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.Calculate(str, col, value)}                                                             *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}