using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosyanovDV.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            int s = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    s *= array[i, 4];
                
            }
            return s;
        }
    }
}
