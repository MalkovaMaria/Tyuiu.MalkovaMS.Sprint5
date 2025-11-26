using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MalkovaMS.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path).Replace(".", ",");
            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '!')
                    res++;
            }

            return res;
        }
    }
}
