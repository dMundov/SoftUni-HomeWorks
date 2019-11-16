using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return   Title + " - " + Content+ ": "+Author;
        }
    }
    class Program
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine()
                 .Split(", ")
                 .ToList();
            Article article = new Article
            {
                Title = input[0],
                Content = input[1],
                Author = input[2]
            };
            for (int i = 0; i < number; i++)
            {
                List<string> newInput = Console.ReadLine()
                    .Split(':')
                    .Select(s => s.Trim())
                    .ToList();

                if (newInput[0] == "Edit")
                {
                    article.Content = newInput[1];
                }
                else if (newInput[0] == "ChangeAuthor")
                {
                    article.Author = newInput[1];
                }
                else if (newInput[0] == "Rename")
                {
                    article.Title = newInput[1];
                }
            }
            string toPrint = article.ToString();
            Console.WriteLine(toPrint);
        }
    }
}


// Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
