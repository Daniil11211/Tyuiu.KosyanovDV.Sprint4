using Tyuiu.KosyanovDV.Sprint4.Task1.V17.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumAr()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 7, 6, 2 };
            int res = ds.Calculate(array);
            int wait = 8;
            Assert.AreEqual(res, wait);
        }
    }
}