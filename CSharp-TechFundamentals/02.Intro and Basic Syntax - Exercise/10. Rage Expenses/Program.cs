using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headSetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboradPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headSets = lostGames/2;
            int mouses = lostGames/3;
            int keyBoards = lostGames/6;
            int displays = lostGames/12;

            decimal totalMouses = mousePrice * (decimal)mouses;
            decimal totalHeadSets = headSetPrice * (decimal)headSets;
            decimal totalKeaboards = keyboradPrice * (decimal)keyBoards;
            decimal totalDisplays = displayPrice * (decimal)displays;

            {
                Console.WriteLine($"Rage expenses: {(totalMouses + totalKeaboards + totalHeadSets + totalDisplays):f2} lv.");
            }
        }
    }
}