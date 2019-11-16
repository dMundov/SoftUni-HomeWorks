using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif


            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            
            for (int i = 0; i < num; i++)
            {
                string[] inputs = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string name = inputs[0];
                double grade = double.Parse(inputs[1]);

                if(!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }               
            }
            foreach (var student in students)
            {
                string name = student.Key;
                var studentGrade = student.Value;
                var average = studentGrade.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrade)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");

            }
        }
    }
}
