using System;

namespace _01._Ages
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            string person = "";


            if (age <= 2)
            {
                person = "baby";
            }
            else if(age > 2 && age<=13)
            {
                person = "child";
            }
            else if(age>13 && age <= 19)
            {
                person = "teenager";
            }
            else if(age>12 && age <=65)
            {
                person = "adult";
            }
            else
            {
                person = "elder";
            }
            Console.WriteLine(person);
        }
    }
}
