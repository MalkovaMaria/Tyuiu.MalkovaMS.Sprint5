using System.IO;
using Tyuiu.MalkovaMS.Sprint5.Task5.V23.Lib;

namespace Tyuiu.MalkovaMS.Sprint5.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
