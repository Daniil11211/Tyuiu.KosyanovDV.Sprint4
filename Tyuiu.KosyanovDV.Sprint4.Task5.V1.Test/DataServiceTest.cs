using Tyuiu.KosyanovDV.Sprint4.Task5.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplace()
        {
            DataService ds = new DataService();
            int[,] array = { { 8, -3, 2 },
                             { -6, 7, 3 },
                             { 4, 5, -4 } };
            int[,] res = ds.Calculate(array);
            int[,] wait = { { 1, -3, 1 },
                            { -6, 1, 1 },
                            { 1, 1, -4 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}