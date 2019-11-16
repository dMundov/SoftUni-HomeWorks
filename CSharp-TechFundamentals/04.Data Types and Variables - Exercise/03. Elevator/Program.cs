using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main()
        {
            int numPeople = int.Parse(Console.ReadLine());
            int numCourses = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numPeople / numCourses);

            Console.WriteLine(courses);
        }
    }
}
