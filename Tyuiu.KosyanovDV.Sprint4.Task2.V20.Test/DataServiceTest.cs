using Tyuiu.KosyanovDV.Sprint4.Task2.V20.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 2, 3, 4 };
            int wait = 6;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}