using Tyuiu.KosyanovDV.Sprint4.Task7.V17.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            string value = "678124917";
            int str = 3;
            int col = 3;
            int wait = 4;
            int res = ds.Calculate(str, col, value);
            
        }
    }
}