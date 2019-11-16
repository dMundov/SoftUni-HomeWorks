using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string status = "";
            string lastBracket = "";


            for (int i = 0; i < num; i++)
            {
                string entry = Console.ReadLine();

                if (entry == "(")
                {
                    if (lastBracket == "(")
                    {
                        status = "UNBALANCE";
                        break;
                    }
                    lastBracket = "(";
                }
                if (entry == ")")
                {
                    if (lastBracket != "(")
                    {
                        status = "UNBALANCED";
                        break;
                    }
                    lastBracket = ")";
                }
                else
                {
                    status = "BALANCED";
                }
            }
            if (lastBracket == "(")
            {
                status = "UNBALANCED";
            }
            Console.WriteLine(status);
        }
    }
}
