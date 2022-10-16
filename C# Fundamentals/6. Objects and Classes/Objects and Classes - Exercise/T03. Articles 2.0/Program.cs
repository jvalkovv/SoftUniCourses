using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Articles2
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> newArti = new List<Article>();

            int numberOfComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                Article newArticle = new Article(
                    input[0],
                    input[1],
                    input[2]);

                newArti.Add(newArticle);
            }

            string orderByWhat = Console.ReadLine();

            //if (orderByWhat == "title")
            //{
            //    newArti = newArti.OrderByDescending(t => t.Title).ToList();
            //}
            // if (orderByWhat == "content")
            //{
            //    newArti = newArti.OrderByDescending(c => c.Content).ToList();
            //}
            // if (orderByWhat == "author")
            //{
            //    newArti = newArti.OrderByDescending(a => a.Author).ToList();
            //}

            Console.WriteLine(string.Join(Environment.NewLine, newArti));
        }
    }
}

