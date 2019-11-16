using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputRoute = @"text.txt";
            using (var reader = new StreamReader(inputRoute))
            {
                int counter = 0;
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    {
                        if (counter % 2 == 0)
                        {
                            line = line.Replace("-", "@")
                                 .Replace(",", "@")
                                 .Replace(".", "@")
                                 .Replace("!", "@")
                                 .Replace("?", "@");

                            string[] reverse = line.Split().Reverse().ToArray();
                            string finalLine = string.Join(" ", reverse);
                            Console.WriteLine(finalLine);

                        }

                    }
                    counter++;
                }

            }
        }
    }
}