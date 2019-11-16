using System;
using System.IO;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int carsNumber = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCarsCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    if (input == "green")
                    {
                        int currentCount = cars.Count > carsNumber ? carsNumber : cars.Count;
                        for (int i = 0; i < currentCount; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCarsCounter++;
                        }
                    }

                    else if (input != "green")
                    {
                        cars.Enqueue(input);
                    }

                }
            }
            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}
