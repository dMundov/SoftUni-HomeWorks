namespace BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Models;

    public class Engine
    {
        private readonly List<IIdentifiable> identifiables;

        public Engine()
        {
            identifiables = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParts = input
                    .Split()
                    .ToArray();

                if (inputParts.Length == 2)
                {
                    AddRobot(inputParts);
                }
                else if (inputParts.Length == 3)
                {
                    AddCitizen(inputParts);
                }

                input = Console.ReadLine();
            }

            var fakeIdDigits = Console.ReadLine();

            foreach (var identifiable in this.identifiables.Where(x => x.Id.EndsWith(fakeIdDigits)))
            {
                Console.WriteLine(identifiable);
            }
        }

        private void AddCitizen(string[] inputParts)
        {
            string citizenName = inputParts[0];
            int age = int.Parse(inputParts[1]);
            string id = inputParts[2];

            IIdentifiable citizen = new Citizen(citizenName, age, id);
            identifiables.Add(citizen);
        }

        private void AddRobot(string[] inputParts)
        {
            string model = inputParts[0];
            string id = inputParts[1];

            IIdentifiable robot = new Robot(model, id);
            identifiables.Add(robot);
        }
    }
}
