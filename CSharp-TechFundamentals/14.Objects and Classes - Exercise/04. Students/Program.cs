using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Students
{
    class Program
    {
        class Student
        {

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:F2}";
            }
        }

        static void Main(string[] args)
        {
            int numbersOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numbersOfStudents; i++)
            {
                string[] studentsInput = Console.ReadLine().Split().ToArray();

                string firstName = studentsInput[0];
                string lastName = studentsInput[1];
                double grade = double.Parse(studentsInput[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            foreach (Student index in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(index);
            }
        }
    }
}
