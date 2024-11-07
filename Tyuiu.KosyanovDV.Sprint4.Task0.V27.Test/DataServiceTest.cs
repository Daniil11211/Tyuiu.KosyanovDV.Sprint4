using Tyuiu.KosyanovDV.Sprint4.Task0.V27.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckArMult()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int wait = 6615;
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}