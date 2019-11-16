using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main()
        {

            double inHours = double.Parse(Console.ReadLine());
            double inMinutes = double.Parse(Console.ReadLine());

            double minutes = inMinutes + 30;
            if(minutes>59)
            {
                inHours += 1;
                minutes -= 60;
            }
            if (inHours > 23)
            {
                inHours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{inHours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{inHours}:{minutes}");
            }
        }
    }
}
