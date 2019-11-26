namespace BookShop
{
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var db = new BookShopContext();
            var input = Console.ReadLine();

            Console.WriteLine(GetBooksByCategory(db,input));

        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> books = new List<string>();

            for (int i = 0; i < categories.Count(); i++)
            {
                books.AddRange(context
                    .Books
                    .Where(b => b.BookCategories.Any(x => x.Category.Name == categories[i]))
                    .Select(b => b.Title)
                    .ToList());
            }

            var sb = new StringBuilder();

            foreach (var b in books.OrderBy(b => b))
            {
                sb.AppendLine(b);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
