using Microsoft.EntityFrameworkCore;

public class Technic : DbContext 
{
    public DbSet<Person> Persons {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=Technics;User=sa; Password = <YourStrong!Passw0rd>");
    }
}