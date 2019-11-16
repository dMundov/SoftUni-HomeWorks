using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double  volume = 0;
          
            volume = (length * width * height) / 3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
