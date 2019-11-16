using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] symbols = input.ToCharArray();

            string numbers ="";
            string letters = "";
            string others = "";
            foreach (var item in symbols)
            {
                if(char.IsDigit((item)))
                {
                    numbers += item;
                }
                else if((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z'))
                {
                    letters += item;
                }
                else if(!char.IsDigit((item)))
                {
                    others += item;
                }
            }
            Console.WriteLine($"{numbers}\n{letters}\n{others}");
        }
    }
}
