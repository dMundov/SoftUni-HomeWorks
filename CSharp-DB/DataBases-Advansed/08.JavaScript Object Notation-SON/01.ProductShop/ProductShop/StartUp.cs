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

            Console.WriteLine( GetProductsInRange(context));



        }

        public static string GetProductsInRange(ProductShopContext context)
        {

            var needProducts = context
                .Products
                .Where(p => p.Price >= 500
                && p.Price <= 1000)
                .Select(p =>
                new ProductDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    SellerName = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .OrderBy(p => p.Price)
                .ToList();

            var getProductsJson = JsonConvert.SerializeObject(needProducts, Formatting.Indented);
            return getProductsJson;
        }





    }
}