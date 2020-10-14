using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;
using BringMeFood.Backend.Persistence;
using System;
using System.Threading.Tasks;

namespace BringMeFood.Backend.Maintenance
{
  class Program
  {
    static void Main(string[] args)
    {
      new Program().Run().GetAwaiter().GetResult();
    }

    private async Task Run()
    {
      using IUnitOfWork uow = new UnitOfWork();

      Console.WriteLine("Perform DB reset ...");
      await uow.ResetDatabaseAsync();
      Console.WriteLine(" [DONE]");

      Store pizzariaDavid = new Store()
      {
        City = "Marchtrenk",
        Street = "Bahnhofstraße 4",
        Postalcode = "4614",
        Name = "Pizzaria David"
      };

      Store pizzariaMetro = new Store()
      {
        City = "Marchtrenk",
        Street = "Haupstraße 2",
        Postalcode = "4614",
        Name = "Pizzaria Metro"
      };

      Console.WriteLine("Create Stores ...");

      await uow.StoreRepository.AddAsync(pizzariaDavid);
      await uow.StoreRepository.AddAsync(pizzariaMetro);
      await uow.SaveAsync();

      Console.WriteLine(" [DONE]");

      Console.WriteLine("Create Meals ...");
      await uow.MealRepository.AddAsync(new Meal { Name = "Wiener Schnitzel", Price = 9.99m });
      await uow.MealRepository.AddAsync(new Meal { Name = "Pizza Diavolo", Price = 8.99m });
      Console.WriteLine(" [DONE]");

      Console.WriteLine("Saving ...");
      await uow.SaveAsync();
      Console.WriteLine(" [DONE]");

    }
  }
}
