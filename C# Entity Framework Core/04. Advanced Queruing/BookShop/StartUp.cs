using System.Globalization;
using System.Text;
using BookShop.Models;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BookShop
{
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);


            //string input = Console.ReadLine();
            //var result = GetBooksByAgeRestriction(db, input);

            //string input = Console.ReadLine();
            //var result = GetGoldenBooks(db);

            //string input = Console.ReadLine();
            //var result = GetBooksByPrice(db);

            //int givenYear = int.Parse(Console.ReadLine());
            //var result = GetBooksNotReleasedIn(db, givenYear);

            //string input = Console.ReadLine();
            //var result = GetBooksByCategory(db, input);

            //string input = Console.ReadLine();
            //var result = GetBooksReleasedBefore(db, input);

            //string input = Console.ReadLine();
            //var result = GetAuthorNamesEndingIn(db, input);

            //string input = Console.ReadLine();
            //var result = GetBookTitlesContaining(db, input);

            //string input = Console.ReadLine();
            //var result = GetBooksByAuthor(db, input);

            //int inputLength = int.Parse(Console.ReadLine());
            //var result = CountBooks(db, inputLength);

            //var result = CountCopiesByAuthor(db);

            //var result = CountCopiesByAuthor(db);

            // var result = GetTotalProfitByCategory(db);

            //var result = GetMostRecentBooks(db);

            int result = RemoveBooks(db);
            Console.WriteLine(result);

        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {

            StringBuilder sb = new StringBuilder();


            var allBook = context.Books.ToList()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => new
                {
                    BookTitle = b.Title
                })
                .OrderBy(b => b.BookTitle)
                .ToList();


            foreach (var b in allBook)
            {
                sb.AppendLine(b.BookTitle);
            }


            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var goldenBook = context.Books
                .ToList().Where(ge => ge.EditionType == EditionType.Gold)
                .Select(t => new
                {
                    BookTitle = t.Title,
                    BookID = t.BookId,
                    Copies = t.Copies
                })
                .Where(t => t.Copies < MagicNumbers.CopiesNumberLessThan5000)
                .OrderBy(b => b.BookID)
                .ToList();


            foreach (var b in goldenBook)
            {
                sb.AppendLine(b.BookTitle);
            }


            return sb.ToString().TrimEnd();

        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();


            var books = context.Books
                .ToList()
                .Where(b => b.Price > MagicNumbers.PriceMoreThan40)
                .Select(t => new
                {
                    TitleName = t.Title,
                    BookPrice = t.Price
                })
                .OrderByDescending(p => p.BookPrice)
                .ToList();


            foreach (var b in books)
            {
                sb.AppendLine($"{b.TitleName} - ${b.BookPrice:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books
                .ToList()
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new
                {
                    BookID = b.BookId,
                    BookTitle = b.Title
                })
                .OrderBy(b => b.BookID)
                .ToList();


            foreach (var b in books)
            {
                sb.AppendLine($"{b.BookTitle}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] inputCategories = input
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var books = context
                .Books
                .Where(b => b.BookCategories.Any(c => inputCategories.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();

            DateTime inputDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .ToList()
                .Where(b => b.ReleaseDate.Value.Date < inputDate)
                .OrderByDescending(rd => rd.ReleaseDate)
                .Select(b => new
                {
                    BookID = b.BookId,
                    BookTitle = b.Title,
                    BookType = b.EditionType.ToString(),
                    BookPrice = b.Price,
                    ReleaseDate = b.ReleaseDate
                })
                .ToList();


            foreach (var b in books)
            {
                sb.AppendLine($"{b.BookTitle} - {b.BookType} - ${b.BookPrice:f2}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var author = context.Authors
                .ToList()
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = a.FirstName + ' ' + a.LastName
                })
                .OrderBy(a => a.FullName)
                .ToList();

            foreach (var a in author)
            {
                sb.AppendLine($"{a.FullName}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books
                .ToList()
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new
                {
                    BookName = b.Title
                })
                .OrderBy(b => b.BookName)
                .ToList();

            foreach (var b in books)
            {
                sb.AppendLine($"{b.BookName}");
            }


            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books
                .Where(a => a.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => new
                {
                    BookTitle = b.Title,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName
                })
                .ToList();

            foreach (var b in books)
            {
                sb.AppendLine($"{b.BookTitle} ({b.FirstName} {b.LastName})");
            }


            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {

            var result = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return result;

        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var bookCopiesByAuthor = context.Authors
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",
                    TotalCopies = a.Books.Sum(c => c.Copies)
                })
                .OrderByDescending(c => c.TotalCopies)
                .ToList();

            foreach (var a in bookCopiesByAuthor)
            {
                sb.AppendLine($"{a.FullName} - {a.TotalCopies}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categoryProfits = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Profit = c.CategoryBooks.Sum(cb => cb.Book.Copies * cb.Book.Price)

                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.CategoryName)
                .ToArray();

            foreach (var c in categoryProfits)
            {
                sb.AppendLine($"{c.CategoryName} ${c.Profit:f2}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var mostRecentBooks = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecentBooks = c.CategoryBooks
                        .OrderByDescending(c => c.Book.ReleaseDate)
                        .Select(cb => new
                        {
                            BookName = cb.Book.Title,
                            YearPublished = cb.Book.ReleaseDate.Value.Year
                        })
                        .Take(3)
                })
                .OrderBy(c => c.CategoryName)
                .ToArray();

            foreach (var category in mostRecentBooks)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.MostRecentBooks)
                {
                    sb.AppendLine($"{book.BookName} ({book.YearPublished})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var booksBefore2010 = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in booksBefore2010)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context
                .Books
                .Where(b => b.Copies < 4200);

            int bookCount = booksToDelete.Count();

            context.Books.RemoveRange(booksToDelete);
            context.SaveChanges();

            return bookCount;
        }
    }
}


