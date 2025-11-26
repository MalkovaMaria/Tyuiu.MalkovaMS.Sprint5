using System.Collections.Specialized;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MalkovaMS.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(".", ",");
            double x = Convert.ToDouble(strX);
            double res = Math.Round(Math.Sin(x) + x * x / 2, 3);
            return res;
        }
    }
}
