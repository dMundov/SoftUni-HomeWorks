using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets); 
            Queue<int> locksQueue = new Queue<int>(locks); 

            int usedBullets = 0;
            bool openedSafe = true;

            while (bulletsStack.Any() && locksQueue.Any())
            {
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();
                }
                usedBullets++;

                if (usedBullets % gunBarrelSize == 0 && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                }

                if (!bulletsStack.Any() && locksQueue.Any())
                {
                    openedSafe = false;
                    break;
                }
            }

            if (openedSafe)
            {
                int bulletCost = usedBullets * bulletPrice;
                int earnedMoney = intelligenceValue - bulletCost;

                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}           
