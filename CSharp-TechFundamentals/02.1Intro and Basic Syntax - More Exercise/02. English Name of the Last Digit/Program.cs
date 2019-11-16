using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int lastDisgit = num % 10;
            string digInEngl = "";

            switch(lastDisgit)
            {
                case 1:
                    digInEngl = "one";
                    break;
                case 2:
                    digInEngl = "two";
                    break;
                case 3:
                    digInEngl = "three";
                    break;
                case 4:
                    digInEngl = "four";
                    break;
                case 5:
                    digInEngl = "five";
                    break;
                case 6:
                    digInEngl = "six";
                    break;
                case 7:
                    digInEngl = "seven";
                    break;
                case 8:
                    digInEngl = "eight";
                    break;
                case 9:
                    digInEngl = "nine";
                    break;
                case 0:
                    digInEngl = "zero";
                    break;
            }
            Console.WriteLine(digInEngl);
        }
    }
}
