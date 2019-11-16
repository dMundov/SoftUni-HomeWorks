using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] inputOrders = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(inputOrders);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                int currentOtder = orders.Peek();
                if (foodQuantity - currentOtder >= 0)
                {
                    foodQuantity -= currentOtder;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
