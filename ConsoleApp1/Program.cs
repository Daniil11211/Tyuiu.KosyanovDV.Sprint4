int[,] array = new int[,] { { -2, 5, 8 }, { 4, 9, -8 }, { 2, 5, 4 } };
int s = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < 0)
        {
            s += array[i, j];
        }
    }
}
Console.WriteLine(s);