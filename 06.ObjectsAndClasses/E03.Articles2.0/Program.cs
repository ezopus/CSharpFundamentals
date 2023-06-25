using System;
using System.Collections.Generic;

namespace E03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int numberOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                article.Override();
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Override()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }

    }
}
