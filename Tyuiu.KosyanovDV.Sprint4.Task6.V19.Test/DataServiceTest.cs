using Tyuiu.KosyanovDV.Sprint4.Task6.V19.Lib;
namespace Tyuiu.KosyanovDV.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            string[] str = { "xd", "Spirin", "ITGalera", "Visit" };
            var res = ds.Calculate(str);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}