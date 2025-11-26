using System.IO;
using Tyuiu.MalkovaMS.Sprint5.Task1.V10.Lib;

namespace Tyuiu.MalkovaMS.Sprint5.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\marim\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
