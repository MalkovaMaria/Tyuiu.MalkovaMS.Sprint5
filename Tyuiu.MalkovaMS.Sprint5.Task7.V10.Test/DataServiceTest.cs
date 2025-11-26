using System.IO;
using Tyuiu.MalkovaMS.Sprint5.Task7.V10.Lib;

namespace Tyuiu.MalkovaMS.Sprint5.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\marim\AppData\Local\Temp\OutPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
