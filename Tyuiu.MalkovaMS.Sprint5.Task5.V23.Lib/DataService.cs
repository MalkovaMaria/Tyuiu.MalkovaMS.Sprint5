using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MalkovaMS.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path).Replace(".", ",");
            string[] nums = str.Split(' ');
            double[] nums1 = new double[nums.Length];
            double res = 100;
            for (int i = 0; i < nums.Length; i++)
            {
                nums1[i] = double.Parse(nums[i]);
                if (nums1[i] % 1 != 0 & nums1[i] < res)
                    res = nums1[i];
            }
            return res;
            
        }
    }
}
