using System.IO;
using Tyuiu.MalkovaMS.Sprint5.Task2.V14.Lib;

namespace Tyuiu.MalkovaMS.Sprint5.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\marim\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
