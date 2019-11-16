using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double mainVolume = 0;
            string biggestKeg = "";

            while (num > 0)
            {
                string model = Console.ReadLine();
                double raduis =double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (raduis * raduis) * height;
                if (mainVolume < volume)
                {
                    mainVolume = volume;
                    biggestKeg = model;
                }
                num--;
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
