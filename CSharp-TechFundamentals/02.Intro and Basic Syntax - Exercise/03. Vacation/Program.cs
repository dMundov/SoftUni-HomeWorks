using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            int numOfPerson = int.Parse(Console.ReadLine());
            string typeOfPerson = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal price = 0;
            decimal totalPrice = 0;
            decimal discount = 0;


            if(typeOfPerson == "Students")
            {
                if(dayOfWeek == "Friday")
                {
                    price = 8.45M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46M;
                }
            }
            else if (typeOfPerson == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16M;
                }              
            }
            else if (typeOfPerson == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50M;
                }     
            }
            if (typeOfPerson == "Students" && numOfPerson >= 30)
            {
                discount = 0.15M;
            }
            else if (typeOfPerson == "Business" && numOfPerson >= 100)
            {
                numOfPerson -= 10;
            }
            else if (typeOfPerson == "Regular" && numOfPerson >= 10 && numOfPerson <= 20)
            {
                discount = 0.05M;
            }
            totalPrice = numOfPerson * price;
            totalPrice = totalPrice - (totalPrice * discount);
            {
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
        }

    }
}
