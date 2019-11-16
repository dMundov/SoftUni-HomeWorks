using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"../../../text.txt";
            string outputFile = @"../../../output.txt";
            string[] lines = File.ReadAllLines(inputFile);
            int counter = 1;
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            foreach (var line in lines)
            {
                int letterCount = 0;
                int marksCount = 0;

                if (line == null)
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];

                        if (!char.IsLetterOrDigit(currentChar) && currentChar != ' ')
                        {
                            marksCount++;
                        }
                        else if (char.IsLetterOrDigit(currentChar))
                        {
                            letterCount++;
                        }

                    }
                    File.AppendAllText(outputFile, $"Line {counter}: {line} ({letterCount})({marksCount}){Environment.NewLine}");
                    counter++;
                }
            }
        }

    }
}



