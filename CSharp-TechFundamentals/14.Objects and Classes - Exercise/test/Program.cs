using System;

namespace _01._GoogleSearches
{
    class Program
    {
        static void Main()
        {

            int totalDays = int.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());

            decimal totalMoney = 0;

            int words = 0;    

            for (int i = 1; i <= numberOfUsers; i++)
            {
                decimal tempMmoney = 0;
                words = int.Parse(Console.ReadLine());

                if (words > 5 || words ==0)
                {
                    continue;
                }
                if (words <= 5)
                {
                    if (words == 1)
                    {
                        tempMmoney += moneyPerSearch * 2;
                        if (i % 3 == 0)
                        {
                            tempMmoney *= 3 ;
                            
                        }
                    }
                    if(words!=1)
                    {
                        tempMmoney += moneyPerSearch;
                        if (i % 3 == 0)
                        {
                            tempMmoney *= 3;
                        }
                    }
                }
                totalMoney += tempMmoney;
            }
            Console.WriteLine($"Total money earned for {totalDays} days: {(totalMoney * totalDays):F2}");
        }
    }
}