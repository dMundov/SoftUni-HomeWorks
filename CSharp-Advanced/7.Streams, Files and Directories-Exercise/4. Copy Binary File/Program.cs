using System;
using System.IO;
using System.Linq;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = @"../../../copyMe.png";
            string copyPath = @"../../../copyOfcopyMe.png";

            using (FileStream streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream(copyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = streamReader.Read(byteArray, 0, byteArray.Length);
                        if(size==0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}