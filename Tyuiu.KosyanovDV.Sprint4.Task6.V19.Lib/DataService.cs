using System.Xml.Linq;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KosyanovDV.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(e => e.Length > 5);
            return count;
        }
    }
}
