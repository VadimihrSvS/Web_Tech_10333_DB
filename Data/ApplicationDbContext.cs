using Lab_WT_Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab_WT_Data.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<DishGroup> Groups { get; set; }

    public ApplicationDbContext()
    {

    }



    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Lab_WT_DB;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}

