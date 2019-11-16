using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Extract_File
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("\\").ToArray();
            int fNamePosition = input.Length - 1;
            string[] fileNamaAndExtension = input[fNamePosition].Split(".").ToArray();

            string filneName = fileNamaAndExtension[0];
            string extension = fileNamaAndExtension[1];


            Console.WriteLine($"File name: {filneName}\nFile extension: {extension}");
        }
    }
}
