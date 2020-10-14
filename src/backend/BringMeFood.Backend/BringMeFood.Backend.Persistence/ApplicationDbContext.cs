using BringMeFood.Backend.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace BringMeFood.Backend.Persistence
{
  class ApplicationDbContext : DbContext
  {
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Store> Stores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Environment.CurrentDirectory)
        .AddJsonFile("appsettings.json")
        .Build();

      optionsBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);
    }
  }
}
