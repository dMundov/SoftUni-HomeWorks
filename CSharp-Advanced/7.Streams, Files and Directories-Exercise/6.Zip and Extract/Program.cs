using System;
using System.IO;
using System.IO.Compression;

namespace _6.Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = @"../../../copyMe.png";
            string pathForArchive = @"../../../result.zip";
            string pathToExtract = @"../../../";

            if (File.Exists(pathForArchive))
            {
                File.Delete(pathForArchive);
            }
            using (FileStream OpenFileToZip = new FileStream(pathForArchive,FileMode.Create))
            {
                using (ZipArchive zipArchive = new ZipArchive(OpenFileToZip,ZipArchiveMode.Create))
                {
                    zipArchive.CreateEntryFromFile(picPath, "newCopyMe.png");
                }
            }
            ZipFile.ExtractToDirectory(pathForArchive, pathToExtract,true);
        }
    }
}
