using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int numOFStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOFStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            foreach (var student in studentGrades.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
