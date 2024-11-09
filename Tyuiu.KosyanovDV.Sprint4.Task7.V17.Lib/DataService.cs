using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KosyanovDV.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(value[i * 3 + j].ToString());
                }
            }
            int count = value.Count(e => e % 2 == 0);
            return count;
        }
    }
}
