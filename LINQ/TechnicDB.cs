using Microsoft.EntityFrameworkCore;

public class Technic : DbContext 
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,2727; Database=Technics;User=sa; Password = Pa$$word1");
    }
}