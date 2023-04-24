using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new ProductShopContext();
            //string inputJson = File.ReadAllText(@"../../../Datasets/categories-products.json");
            string result = GetUsersWithProducts(db);

            Console.WriteLine(result);
        }
        private static IMapper CreateMapper()
        {
            return new Mapper(new MapperConfiguration(conf =>
            {
                conf.AddProfile<ProductShopProfile>();
            }));
        }

        private static IContractResolver ConfigCamelCaseNaming()
        {
            return new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy(false, true)
            };
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));

            ImportUserDto[] userDTOs = JsonConvert.DeserializeObject<ImportUserDto[]>(inputJson);

            ICollection<User> validUsers = new HashSet<User>();

            foreach (ImportUserDto userDto in userDTOs)
            {
                User user = mapper.Map<User>(userDto);
                validUsers.Add(user);
            }

            context.AddRange(validUsers);
            context.SaveChanges();

            return $"Successfully imported {validUsers.Count}";

        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));

            ImportProductDto[] productDTOs = JsonConvert.DeserializeObject<ImportProductDto[]>(inputJson);

            Product[] products = mapper.Map<Product[]>(productDTOs);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));

            ImportCategoryDto[] categoryDto = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);

            ICollection<Category> validCategories = new HashSet<Category>();

            foreach (var cdtos in categoryDto)
            {
                if (string.IsNullOrEmpty(cdtos.Name))
                {
                    continue;
                }

                var category = mapper.Map<Category>(cdtos);
                validCategories.Add(category);
            }
            context.Categories.AddRange(validCategories);
            context.SaveChanges();

            return $"Successfully imported {validCategories.Count}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCategoryProductDto[] categoryDtos = JsonConvert.DeserializeObject<ImportCategoryProductDto[]>(inputJson);

            CategoryProduct[] categoryProduct = mapper.Map<CategoryProduct[]>(categoryDtos);

            context.CategoriesProducts.AddRange(categoryProduct);
            context.SaveChanges();

            return $"Successfully imported {categoryProduct.Length}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            IContractResolver contractResolver = ConfigCamelCaseNaming();

            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    Seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(products,
                Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ContractResolver = contractResolver
                });

        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            IContractResolver contractResolver = ConfigCamelCaseNaming();

            var buyer = context.Users
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    SoldProducts = u.ProductsSold
                        .Where(p => p.Buyer != null)
                        .Select(p => new
                        {
                            p.Name,
                            p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        })
                        .ToArray()
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(buyer, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ContractResolver = contractResolver
                });
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            IContractResolver contractResolver = ConfigCamelCaseNaming();

            var products = context.Categories
                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.CategoriesProducts.Count(),
                    AveragePrice = c.CategoriesProducts.Average(p => p.Product.Price).ToString("0.00"),
                    TotalRevenue = c.CategoriesProducts.Sum(p => p.Product.Price).ToString("0.00")
                })
                .OrderByDescending(c => c.ProductsCount)
                .AsNoTracking()
                .ToArray();


            return JsonConvert.SerializeObject(products, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ContractResolver = contractResolver
                });
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {

            IContractResolver contractResolver = ConfigCamelCaseNaming();


            var usersCount = context.Users.Count();

            var users = context.Users
            .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
            .Select(u => new
            {
                u.FirstName,
                u.LastName,
                u.Age,
                SoldProducts = new
                {
                    Count = u.ProductsSold.Count(u => u.Buyer != null),
                    Products = u.ProductsSold
                        .Where(p => p.Buyer != null)
                            .Select(p => new
                            {
                                p.Name,
                                p.Price
                            })
                        .ToArray()
                }
            })
            .OrderByDescending(p => p.SoldProducts.Count)
            .AsNoTracking()
            .ToArray();

            var result = new
            {
                UsersCount = users.Length,
                Users = users
            };

            return JsonConvert.SerializeObject(result,
                Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ContractResolver = contractResolver,
                    NullValueHandling = NullValueHandling.Ignore
                });
        }

    }
}