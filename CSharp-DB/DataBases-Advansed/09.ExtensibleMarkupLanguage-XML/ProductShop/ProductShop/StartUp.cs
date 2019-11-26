namespace ProductShop
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    using ProductShop.Data;
    using ProductShop.Models;
    using ProductShop.Dtos.Import;
    using System.Collections.Generic;
    using ProductShop.Dtos.Export;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new ProductShopContext())
            {
                var inputXmlDoc = File.ReadAllText(@"..\..\..\Datasets\categories-products.xml");
                
                Console.WriteLine();
                //use method you need
                Console.WriteLine();
            }

        }
        
                        //------FirstPart--ImportDataInDB-----
         
        // 01. Import Users
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var users = new List<User>();
            using (var reader = new StringReader(inputXml))
            {
                var xmlSerializer = new XmlSerializer(typeof(ImportUserDto[]), new XmlRootAttribute("Users"));
                var userDtos = (ImportUserDto[])xmlSerializer.Deserialize(reader);

                users = userDtos
                   .Select(ud => new User
                   {
                       FirstName = ud.FirstName,
                       LastName = ud.LastName,
                       Age = ud.Age
                   })
                   .ToList();

                context.Users.AddRange(users);
                var importedCount = context.SaveChanges();
            }

            return $"Successfully imported {users.Count}";
        }
        // 02. Import Products

        public static string ImportProducts(ProductShopContext context, string inputXml)


        {

            var productToImport = new List<Product>();
            using (var reader = new StringReader(inputXml))
            {
                var xmlSerializer = new XmlSerializer(typeof(ImportProductDto[]), new XmlRootAttribute("Products"));
                var productDto = (ImportProductDto[])xmlSerializer.Deserialize(reader);

                productToImport = productDto
                   .Select(pd => new Product
                   {
                       Name = pd.Name,
                       Price = pd.Price,
                       SellerId = pd.SellerId,
                       BuyerId = pd.BuyerId

                   })
                   .ToList();

                context.Products.AddRange(productToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {productToImport.Count}";
        }

        //03. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputXml)

        {
            var categoriesToImport = new List<Category>();
            using (var reader = new StringReader(inputXml))
            {
                var xmlSerializer = new XmlSerializer(typeof(ImportCategoryDto[]), new XmlRootAttribute("Categories"));
                var categoryDtos = (ImportCategoryDto[])xmlSerializer.Deserialize(reader);

                categoriesToImport = categoryDtos
                   .Select(cd => new Category
                   {
                       Name = cd.Name
                   })
                   .ToList();

                context.Categories.AddRange(categoriesToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {categoriesToImport.Count}";


        }
       
        // 04. Import Categories and Products 

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var catProductsToImport = new List<CategoryProduct>();
            using (var reader = new StringReader(inputXml))
            {
                var xmlSerializer = new XmlSerializer(typeof(ImportCategoryProdutcDto[]), new XmlRootAttribute("CategoryProducts"));
                var categoryProductsDtos = (ImportCategoryProdutcDto[])xmlSerializer.Deserialize(reader);

                catProductsToImport = categoryProductsDtos
                   .Select(d => new CategoryProduct
                   {
                       CategoryId = d.CategoryId,
                       ProductId = d.ProductId

                   })
                   .ToList();

                context.CategoryProducts.AddRange(catProductsToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {catProductsToImport.Count}";

        }
        
                            //-----SecondPart-GetDataFromDB----

        //05. Export Products In Range 
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ProductInRangeDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                })
                .Take(10)
                .ToArray();

            var productsXml = new StringBuilder();
            using (var writer = new StringWriter())
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(
                    typeof(ProductInRangeDto[]),
                    new XmlRootAttribute("Products"));
                serializer.Serialize(writer, products, ns);

                 productsXml = writer.GetStringBuilder();
            }
            return productsXml.ToString().TrimEnd();
        }
        //06. Export Sold Products 
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new UserDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                        .Where(ps => ps.Buyer != null)
                        .Select(ps => new UserProductDto
                        {
                            Name = ps.Name,
                            Price = ps.Price
                        })
                        .ToArray()
                })
                .Take(5)
                .ToArray();
            var soldProductsXml = new StringBuilder();
            using (var writer = new StringWriter()) 
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(typeof(UserDto[]), new XmlRootAttribute("Users"));
                serializer.Serialize(writer, users, ns);

                soldProductsXml = writer.GetStringBuilder();
            }
            return soldProductsXml.ToString().TrimEnd();
        }
        //07. Export Categories By Products Count 
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categoryDtos = context.Categories
                .Select(c => new CategoryByProductDto
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts
                        .Average(p => p.Product.Price),
                    TotalRevenue = c.CategoryProducts
                        .Sum(p => p.Product.Price)
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            var resultXml = new StringBuilder();
            using (var writer = new StringWriter())
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(
                    typeof(CategoryByProductDto[]),
                    new XmlRootAttribute("Categories"));
                serializer.Serialize(writer, categoryDtos, ns);

                resultXml = writer.GetStringBuilder();
            }
            return resultXml.ToString().TrimEnd();
        }

        //08. Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(p => p.ProductsSold.Count())
                .Select(u => new UserWithProductsDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductDto
                    {
                        Count = u.ProductsSold.Count(),
                        Products = u.ProductsSold
                            .Select(p => new ProductDto
                            {
                                Name = p.Name,
                                Price = p.Price
                            })
                            .OrderByDescending(p => p.Price)
                            .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            var userAndProducts = new UserAndProductsDto
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = users
            };

            var userAndProductsXml = new StringBuilder();
            using (var writer = new StringWriter())
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(typeof(UserAndProductsDto), new XmlRootAttribute("Users"));
                serializer.Serialize(writer, userAndProducts, ns);

                 userAndProductsXml = writer.GetStringBuilder();
            }
            return userAndProductsXml.ToString().TrimEnd();
        }
    }
}
    