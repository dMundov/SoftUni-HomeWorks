using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            string[] phrases = new string[] { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = new string[] { "Diana",
                "Petya", "Stella",
                "Elena", "Katya",
                "Iva", "Annie", "Eva" };
            string[] cities = new string[]
            { "Burgas",
              "Sofia", "Plovdiv",
              "Varna", "Ruse" };

            Random phrase = new Random();
            Random eventt = new Random();
            Random author = new Random();
            Random town = new Random();

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);
                int eventIndex = phrase.Next(0, events.Length);
                int authorIndex = phrase.Next(0, authors.Length);
                int citiesIndex = phrase.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[citiesIndex]}");
            }
        }
    }
}