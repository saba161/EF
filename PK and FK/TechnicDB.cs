using Microsoft.EntityFrameworkCore;

public class Technic : DbContext 
{
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Order> Orders {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,2727; Database=Technics;User=sa; Password = Pa$$word1");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Customer>()
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}