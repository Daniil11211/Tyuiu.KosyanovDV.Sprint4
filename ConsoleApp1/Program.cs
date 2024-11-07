int[] array  = new int[] { 8, 0, 4, 4, 2, 3 } ;
int m = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        m += array[i];
    }
}
Console.WriteLine(m);