namespace Animals
{
    using System;
    using System.Text;

    public class Animal
    {
        private int age;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; private set; }

        public int Age
        {
            get => age;

            protected set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                age = value;
            }
        }

        public string Gender { get; private set; }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{Name} {Age} {Gender}");
            result.AppendLine(ProduceSound());

            return result.ToString().TrimEnd();
        }
    }
}