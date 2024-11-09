using Tyuiu.KosyanovDV.Sprint4.Task4.V24.Lib;

namespace Tyuiu.KosyanovDV.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplace()
        {
            DataService ds = new DataService();
            int[,] array = { { 8, 3, 2 },
                             { 6, 7, 3 },
                             { 4, 5, 4 } };
            int[,] res = ds.Calculate(array);
            int[,] wait = { { 1, 3, 1 },
                            { 1, 7, 3 },
                            { 1, 5, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}