using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = RectAngleArea(width, height);
            Console.WriteLine(area);
                    
        }

        static double RectAngleArea(double width, double heigth)
        {
            return width * heigth;
        }
    }
}
