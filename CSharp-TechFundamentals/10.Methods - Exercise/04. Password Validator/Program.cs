using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passInput = Console.ReadLine();
            
            bool passLenght = PassLenght(passInput);
            bool passLettersAndDigits = PassLettersAndDigits(passInput);
            bool passDigitsCounter = DigitCounter(passInput);

            if (passLenght && passLettersAndDigits && passDigitsCounter)
            {
                Console.WriteLine("Password is valid");
            }
            if (!passLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!passLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!passDigitsCounter)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool PassLenght(string pass)
        {
            bool isInRange = false;
            int charCounter = 0;
            foreach (var item in pass)
            {
                charCounter++;
            }
            if (charCounter >= 6 && charCounter <= 10)
            {
                isInRange = true;
            }
            return isInRange;
        }
        private static bool DigitCounter(string pass)
        {
            bool IsMoreThen2 = false;
            int counter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((char.IsDigit(pass[i])))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                IsMoreThen2 = true;
            }
            return IsMoreThen2;
        }

        private static bool PassLettersAndDigits(string pass)
        {
            bool IsLettersAndDigitsOnly = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if (!char.IsLetterOrDigit(pass[i]))
                {
                    IsLettersAndDigitsOnly = false;
                }
            }
            return IsLettersAndDigitsOnly;
        }


    }
}