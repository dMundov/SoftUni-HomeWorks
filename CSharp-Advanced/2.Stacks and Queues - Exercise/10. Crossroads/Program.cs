using System;
using System.Collections.Generic;
using System.IO;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif


            int secondsGreenlight = int.Parse(Console.ReadLine());
            int additionalSeconds = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    var currentSecondsStart = secondsGreenlight;

                    while (currentSecondsStart > 0 && cars.Count > 0)
                    {
                        var currentCar = cars.Peek();

                        if (currentCar.Length <= currentSecondsStart)
                        {
                            cars.Dequeue();
                            counter++;
                        }
                        else if (currentCar.Length <= currentSecondsStart + additionalSeconds)
                        {
                            cars.Dequeue();
                            counter++;
                        }
                        else
                        {
                            var car = new Queue<char>(cars.Peek());

                            for (int i = 0; i < currentSecondsStart + additionalSeconds; i++)
                            {
                                car.Dequeue();
                            }

                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {car.Peek()}.");
                            return;
                        }
                        currentSecondsStart -= currentCar.Length;
                    }
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
