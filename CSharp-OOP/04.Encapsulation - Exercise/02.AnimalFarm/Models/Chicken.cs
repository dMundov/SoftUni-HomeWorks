namespace AnimalFarm.Models
{
    public class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
               return name;
            }


            private set
            {
                Validator.ValidateName(value);

                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }


            private set
            {
                Validator.ValidateAge(value);

                age = value;
            }
        }

        public double ProductPerDay
            => CalculateProductPerDay();

        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {this.ProductPerDay} eggs per day.";
        }

        private double CalculateProductPerDay()
        {
            switch (Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}