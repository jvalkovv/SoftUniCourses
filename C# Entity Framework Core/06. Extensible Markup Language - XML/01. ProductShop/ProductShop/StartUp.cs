using AutoMapper;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using static ProductShop.DTOs.Import.ImportUserDto;

namespace ProductShop
{
    public class StartUp
    {
        private static IMapper InitializeAutoMapper()
            => new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));
        public static void Main()
        {
            var db = new ProductShopContext();

            string inputXML = File.ReadAllText(@"../../../Datasets/products.xml");
            var result = ImportProducts(db, inputXML);

            Console.WriteLine(result);

        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            IMapper mapper = InitializeAutoMapper();

            XmlHelper xmlHelper = new XmlHelper();
            ImportUserDto[] usersDtos =
                xmlHelper.Deserialize<ImportUserDto[]>(inputXml, "Users");

            ICollection<User> validUsers = new HashSet<User>();

            foreach (var u in usersDtos)
            {
                if (string.IsNullOrEmpty(u.FirstName) || string.IsNullOrEmpty(u.LastName))
                {
                    continue;
                }
                User users = mapper.Map<User>(u);

                validUsers.Add(users);
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            return $"Successfully imported {validUsers.Count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            IMapper mapper = InitializeAutoMapper();

            XmlHelper xmlHelper = new XmlHelper();

            ImportProductDto[] importProductDtos =
                xmlHelper.Deserialize<ImportProductDto[]>(inputXml, "Products");


            ICollection<Product> validProducts = new HashSet<Product>();

            foreach (var p in importProductDtos)
            {
                if (string.IsNullOrEmpty(p.Name))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(p.SellerId.ToString()))
                {
                    continue;
                }

                Product product = mapper.Map<Product>(p);
                validProducts.Add(product);
            }

            context.Products.AddRange(validProducts);

            context.SaveChanges();

            return $"Successfully imported {validProducts.Count}";

        }

    }
}