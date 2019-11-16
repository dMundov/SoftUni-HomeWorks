using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Person> personDetails = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] inputdetails = input.Split();

                string name = inputdetails[0];
                string iD = inputdetails[1];
                int age = int.Parse(inputdetails[2]);

                Person person = new Person(name, iD, age);
                personDetails.Add(person);
            }
            List<Person> finalList = personDetails.OrderBy(x => x.Age).ToList();
            foreach (Person person in finalList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}