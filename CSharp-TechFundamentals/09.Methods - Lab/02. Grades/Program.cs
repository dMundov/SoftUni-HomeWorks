using System;

namespace _02._Grades
{
    class Program
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            GradesPower(grade);
        }

        public static void GradesPower(double grades)
        {
            var result = "";
            if (grades >= 2.00 && grades <= 2.99)
            {
                result = "Fail";
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                result = "Poor";
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                result = "Good";
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                result = "Very good";
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                result = "Excellent";
            }
            Console.WriteLine(result);
        }
    }
}
