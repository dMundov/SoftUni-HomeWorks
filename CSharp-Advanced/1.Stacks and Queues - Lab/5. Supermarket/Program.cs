using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> customers = new Queue<string>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input=="End")
                {
                    break;

                }
                else
                {
                    if(input!="Paid")
                    {
                        customers.Enqueue(input);
                    }
                    else if(input=="Paid")
                    {
                        while(customers.Count>0)
                        Console.WriteLine(customers.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
