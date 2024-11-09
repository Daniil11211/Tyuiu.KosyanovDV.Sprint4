using Tyuiu.KosyanovDV.Sprint4.Task3.V21.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            int res = ds.Calculate(array);
            int wait = 18;
            Assert.AreEqual(res, wait);
        }
    }
}