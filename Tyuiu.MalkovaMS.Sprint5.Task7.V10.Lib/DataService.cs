using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MalkovaMS.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
                File.Delete(pathSaveFile);
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine = strLine + char.ToLower(line[i]);
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
