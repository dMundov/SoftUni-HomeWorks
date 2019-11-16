using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(" ").ToArray();
            string[] array2 = Console.ReadLine().Split(" ").ToArray(); 

            string strToPrint = "";

            for (int i = 0; i < array2.Length; i++)
            {

                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {

                        if (i == array2.Length)
                        {
                            strToPrint += array2[i];
                        }
                        else
                        {
                            strToPrint += array2[i] + " ";
                        }
                    }
                }                
            }
            Console.WriteLine(strToPrint);
        }
    }
}
