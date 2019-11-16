using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secInput = int.Parse(Console.ReadLine());
                GetMaxInt(firstInput,secInput);
            }
            else if(type== "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secInput = char.Parse(Console.ReadLine());
                GetMaxChar(firstInput,secInput);
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secInput = Console.ReadLine();
                GetMaxString(firstInput, secInput);
            }



        }

        private static void GetMaxInt(int firstInt, int secInt)
        {
            if (firstInt > secInt)
            {
                Console.WriteLine(firstInt);
            }
            else
            {
                Console.WriteLine(secInt);
            }
        }
        private static void GetMaxChar(char firstChar, char secChar)
        {
            if (firstChar > secChar)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secChar);
            }
        }

        private static void GetMaxString(string firstString, string secString)
        {

           
            if (String.Compare(firstString, secString, StringComparison.Ordinal)>0)
            {
                Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secString);
            }
        }

    }
}
