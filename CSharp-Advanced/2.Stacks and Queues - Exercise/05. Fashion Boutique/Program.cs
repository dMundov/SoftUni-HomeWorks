using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int[] clothes = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clotesStack = new Stack<int>(clothes);
            int racks = 1;
            int sum = 0;
            while(clotesStack.Count>0)
            {
                if(sum + clotesStack.Peek()<=capacity)
                {
                    sum+=clotesStack.Pop(); 
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
