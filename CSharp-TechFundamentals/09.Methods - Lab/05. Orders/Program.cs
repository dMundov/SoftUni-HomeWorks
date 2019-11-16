using System;
namespace _05._Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateTotalPrice(product,quantity);
        }

        static void CalculateTotalPrice(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(quantity*1.50M);
                    break;
                case "water":
                    Console.WriteLine(quantity * 1.00M);
                    break;
                case "coke":
                    Console.WriteLine(quantity * 1.40M);
                    break;
                case "snacks":
                    Console.WriteLine(quantity * 2.00M);
                    break;
            }
        }
    }
}
