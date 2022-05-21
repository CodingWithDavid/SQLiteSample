using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace SQLiteSample
{
    internal class Program
    {
        static void Main()
        {
           using var db = new BlogContext();

            db.Database.Migrate();

            if (!db.Posts.Any())
            {
                Console.WriteLine("Adding sample data...");

                db.AddRange(
                    new Post { Title = "Intro to migrations" },
                    new Post { Title = "Migrations in Team Environments" },
                    new Post { Title = "Advance Migrations" });

                db.SaveChanges();

                Console.WriteLine("Posts...");

                foreach (var post in db.Posts)
                {
                    Console.WriteLine($"    {post.Title}");
                }
            }
            else
            {
                Console.WriteLine("Current Posts...");
                foreach (var post in db.Posts)
                {
                    Console.WriteLine($"    {post.Title}");
                }
            }
        }
    }
}
