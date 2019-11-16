using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();

            string lang = "";


            if(country=="USA"||country=="England")
            {
                lang = "English";
            }
            else if(country=="Spain"||country=="Argentina"||country=="Mexico")
            {
                lang = "Spanish";
            }
            else
            {
                lang = "unknown";
            }
            Console.WriteLine($"{lang}");
        }
    }
}
