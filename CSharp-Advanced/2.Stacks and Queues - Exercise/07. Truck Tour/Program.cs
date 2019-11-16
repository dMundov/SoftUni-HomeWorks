using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int num = int.Parse(Console.ReadLine());

            Queue<int> ourQueue = new Queue<int>();
            

            for (int i = 0; i < num; i++)
            {
                int[] pumpValues = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();

                ourQueue.Enqueue(pumpValues[0] - pumpValues[1]);
            }
            
            int index = 0;
            while (true)
            {
                Queue<int> copyOurQueue = new Queue<int>(ourQueue);
                int fuel = -1;

                while (copyOurQueue.Any())
                {

                    if (copyOurQueue.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyOurQueue.Dequeue();
                        ourQueue.Enqueue(ourQueue.Dequeue());
                    }
                    else if (copyOurQueue.Peek() < 0 && fuel == -1)
                    {
                        copyOurQueue.Enqueue(copyOurQueue.Dequeue());
                        ourQueue.Enqueue(ourQueue.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyOurQueue.Dequeue();
                        if (fuel < 0)
                        {

                            break;
                        }
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
            
        }
    }
}
