using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            decimal priceSabers = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());
            int freeBelts = 0;
            for (int i = 6; i <= countOfStudents; i += 6)
            {
                freeBelts++;
            }

            decimal allPriceSabers = priceSabers *
                 (Math.Ceiling((decimal)countOfStudents 
                 +(countOfStudents * 0.10M)));
            decimal allRobesPrices = priceRobes * ((decimal)countOfStudents);
            decimal allPriceBelts=  priceBelts*((decimal)countOfStudents - freeBelts);
            decimal allPrice = allPriceSabers +allRobesPrices + allPriceBelts;

            if(amountOfMoney>=allPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(allPrice-amountOfMoney):f2}lv more.");
            }
        }
    }
}
