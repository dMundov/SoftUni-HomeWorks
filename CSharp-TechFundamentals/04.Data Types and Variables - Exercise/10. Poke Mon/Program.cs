using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            decimal pokeDevide = pokePower / 2M;
            int targets = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;       
                targets++;
                if (pokePower == pokeDevide && exhaustionFactor > 0)
                {
                        pokePower = (int)(pokePower / exhaustionFactor);   
                }
            }
            Console.WriteLine($"{pokePower}\n{targets}");
        }
    }
}
