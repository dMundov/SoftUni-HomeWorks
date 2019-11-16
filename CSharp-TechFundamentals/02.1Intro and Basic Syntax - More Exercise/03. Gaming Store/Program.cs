using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBallance = decimal.Parse(Console.ReadLine());

            decimal gamePrice = 0;
            decimal allspent = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (currentBallance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                if (game == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${allspent}. Remaining: ${currentBallance}");
                    break;
                }
                else
                {
                    if (game == "OutFall 4")
                    {
                        gamePrice = 39.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    if (game == "CS: OG")
                    {
                        gamePrice = 15.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    if (game == "Zplinter Zell")
                    {
                        gamePrice = 19.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    if (game == "Honored 2")
                    {
                        gamePrice = 59.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    if (game == "RoverWatch")
                    {
                        gamePrice = 29.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    if (game == "RoverWatch Origins Edition")
                    {
                        gamePrice = 39.99M;
                        if (currentBallance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (currentBallance >= gamePrice)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBallance -= gamePrice;
                            allspent += gamePrice;
                        }
                    }
                    else if (game != "OutFall 4"
                        && game != "CS: OG"
                        && game != "Honored 2"
                        && game != "Zplinter Zell"
                        && game != "RoverWatch"
                        && game != "RoverWatch Origins Edition")
                    {
                        Console.WriteLine("Not Found");
                    }
                }

            }
        }
    }
}

