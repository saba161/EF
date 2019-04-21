using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
            {
                context.VideoGames.Add(new VideoGame() { Title = "Kogoia" , Platform = 1999});
                context.SaveChanges();
            }
        }
    }

    public class VideoGame {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Platform { get; set; }
    }

    public class VideoGamesDatabaseContext : DbContext
    {
        public DbSet<VideoGame> VideoGames {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Server=localhost; Database=VideoGames;User=SA; Password=<YourStrong!Passw0rd>");
        }
    }
}
