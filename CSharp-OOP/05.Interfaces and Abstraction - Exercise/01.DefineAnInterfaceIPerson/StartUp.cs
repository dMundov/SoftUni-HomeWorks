namespace PersonInfo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string personName = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());

            IPerson person = new Citizen(personName, personAge);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}