using Microsoft.EntityFrameworkCore;

public class VideoGamesDatabaseContext : DbContext
{
    public DbSet<VideoGame> VideoGames {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=VideoGames;User=SA; Password=Password1234");
    }
}