using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main()
        {
            string user = Console.ReadLine();
            string passAtemp = Console.ReadLine();
            string pass = new string(user.Reverse().ToArray());
            int counter = 0;
            while (true)
            {
                if (pass != passAtemp)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                    passAtemp = Console.ReadLine();
                }
                if (pass == passAtemp)
                {
                    {
                        Console.WriteLine($"User {user} logged in.");
                        break;
                    }
                }
                if (counter >= 3)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
            }
        }
    }
}
