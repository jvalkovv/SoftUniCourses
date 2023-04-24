using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using Castle.Core.Internal;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;

namespace CarDealer
{
    public class StartUp
    {
        private static IMapper CreateMapper()
        {
            return new Mapper(new MapperConfiguration(conf =>
            {
                conf.AddProfile<CarDealerProfile>();
            }));
        }

        private static IContractResolver ConfigCamelCaseNaming()
        {
            return new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy(false, true)
            };
        }
        public static void Main()
        {
            var db = new CarDealerContext();
            //string inputJson = File.ReadAllText(@"../../../Datasets/sales.json");
            //var result = ImportSales(db, inputJson);

            string result = GetSalesWithAppliedDiscount(db);
            Console.WriteLine(result);
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            List<ImportSupplierDto> importSupplierDtos = JsonConvert.DeserializeObject<List<ImportSupplierDto>>(inputJson);

            List<Supplier> suppliers = mapper.Map<List<Supplier>>(importSupplierDtos);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {

            IMapper mapper = CreateMapper();

            ImportPartDto[] importPartDtos = JsonConvert.DeserializeObject<ImportPartDto[]>(inputJson);

            ICollection<Part> validParts = new HashSet<Part>();

            foreach (var partDto in importPartDtos)
            {
                if (context.Suppliers.Any(s => s.Id == partDto.SupplierId) &&
                    context.Suppliers.Any(s => s.IsImporter == true))
                {
                    validParts.Add(mapper.Map<Part>(partDto));
                }
            }

            context.Parts.AddRange(validParts);
            context.SaveChanges();



            return $"Successfully imported {validParts.Count}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCarDto[] importCars = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

            ICollection<Car> validCars = new HashSet<Car>();
            ICollection<PartCar> validPart = new HashSet<PartCar>();

            foreach (var carDtos in importCars)
            {
                Car car = mapper.Map<Car>(carDtos);
                validCars.Add(car);

                foreach (var partId in carDtos.PartId.Distinct())
                {
                    PartCar partCar = new PartCar()
                    {
                        Car = car,
                        PartId = partId
                    };
                    validPart.Add(partCar);
                }
            }

            context.Cars.AddRange(validCars);
            context.PartsCars.AddRange(validPart);
            context.SaveChanges();

            return $"Successfully imported {validCars.Count}.";
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCustomerDto[] importCustomer = JsonConvert.DeserializeObject<ImportCustomerDto[]>(inputJson);


            var customer = mapper.Map<Customer[]>(importCustomer);

            context.Customers.AddRange(customer);
            context.SaveChanges();


            return $"Successfully imported {customer.Length}.";
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportSaleDto[] importSales =
                JsonConvert.DeserializeObject<ImportSaleDto[]>(inputJson);

            var sales = mapper.Map<Sale[]>(importSales);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}.";
        }


        public static string GetOrderedCustomers(CarDealerContext context)
        {
            IContractResolver contractResolver = ConfigCamelCaseNaming();

            var customer = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.Date.ToString("dd/MM/yyyy"),
                    IsYoungDriver = c.IsYoungDriver
                })
                .AsNoTracking()
                .ToArray();


            return JsonConvert.SerializeObject(customer, Formatting.Indented);


        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {

            var toyotaCar = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(m => m.Model)
                .ThenByDescending(t => t.TraveledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                })
                .AsNoTracking()
                .ToArray();


            return JsonConvert.SerializeObject(toyotaCar, Formatting.Indented);
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {

            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {

            var cars = context
                .Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        TraveledDistance = c.TraveledDistance
                    },
                    parts = c.PartsCars
                        .Select(p => new
                        {
                            Name = p.Part.Name,
                            Price = p.Part.Price.ToString("f2")
                        })
                        .ToArray()
                })
                .AsNoTracking()
                .ToArray();


            return JsonConvert.SerializeObject(cars, Formatting.Indented);

        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            IContractResolver contractResolver = ConfigCamelCaseNaming();

            var totalSalesByCustomer = context
                .Customers
                .Where(c => c.Sales.Count > 0)
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.SelectMany(s => s.Car.PartsCars).Sum(m => m.Part.Price)
                })
                .OrderByDescending(m => m.SpentMoney)
                .ThenByDescending(c => c.BoughtCars)
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(totalSalesByCustomer, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ContractResolver = contractResolver
                });
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            /* Get first 10 sales with information about the car, customer and price of the sale with and without discount.
             Export the list of sales to JSON in the format provided below.*/


            var sales = context
                .Sales
                .Take(10)
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Car.Make,
                        Model = c.Car.Model,
                        TraveledDistance = c.Car.TraveledDistance
                    },
                    customerName = c.Customer.Name,
                    discount = c.Discount.ToString("f2"),
                    price = c.Car.Sales.SelectMany(s => s.Car.PartsCars).Sum(m => m.Part.Price).ToString("f2"),

                    priceWithDiscount =
                        (c.Car.PartsCars
                        .Sum(cp => cp.Part.Price) * (100 - c.Discount) / 100).ToString("f2")
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);

        }
    }
}