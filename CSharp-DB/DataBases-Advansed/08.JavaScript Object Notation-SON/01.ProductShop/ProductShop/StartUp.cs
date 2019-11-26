using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var context = new ProductShopContext();

            Console.WriteLine(GetUsersWithProducts(context));


        }


        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {

            var categories = context
                .Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = $"{c.CategoryProducts.Average(p => p.Product.Price):F2}",
                    totalRevenue = $"{c.CategoryProducts.Sum(p => p.Product.Price):F2}"
                })
                .OrderByDescending(p => p.productsCount)
                .ToList();

            var jsonCategories = JsonConvert.SerializeObject(categories, Formatting.Indented);
            return jsonCategories;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {

            var users = context
                .Users
                .Where(u => u.ProductsSold.Any((ps => ps.Buyer != null)))
                .OrderByDescending(u => u.ProductsSold.Count(ps => ps.Buyer != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Count(ps => ps.Buyer != null),
                        products = u.ProductsSold
                            .Where(p => p.Buyer != null)
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })
                    }
                })
                .ToList();


            var finalUsers = new
            {
                usersCount = users.Count(),
                users
            };

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var usersJason = JsonConvert.SerializeObject(finalUsers, Formatting.Indented, settings);

            return usersJason;

        }

    }
}