using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dirInfo = new Dictionary<string, Dictionary<string, double>>();

            string[] fileArray = Directory.GetFiles(".", "*.*");
            DirectoryInfo directoryInfo = new DirectoryInfo(".");


            var allFiles = directoryInfo.GetFiles();

            foreach (var file in allFiles)
            {
                var fileSize = file.Length / 1024D;
                var fileName = file.Name;
                var extension = file.Extension;
                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, fileSize);
                }

            }
            string desktopPath = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop)
                + @"/report.txt";

            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            if (File.Exists(desktopPath))
            {
                File.Delete(desktopPath); 
            }
            foreach (var (extnesion, value) in sortedDictionary)
            {
                File.AppendAllText(desktopPath, extnesion + Environment.NewLine);
                foreach (var (filename, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(desktopPath, $"--{filename:f3} - {size:F3} kb{ Environment.NewLine}");
                }
            }

        }
    }
}
