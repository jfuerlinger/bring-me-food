using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Persistence.Repositories;
using System.Threading.Tasks;

namespace BringMeFood.Backend.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationDbContext _dbContext;

    public IMealRepository MealRepository { get; private set; }
    public ICustomerRepository CustomerRepository { get; private set; }
    public IOrderRepository OrderRepository { get; private set; }
    public IStoreRepository StoreRepository { get; private set; }

    public UnitOfWork()
    {
      _dbContext = new ApplicationDbContext();

      MealRepository = new MealRepository(_dbContext);
      CustomerRepository = new CustomerRepository(_dbContext);
      OrderRepository = new OrderRepository(_dbContext);
      StoreRepository = new StoreRepository(_dbContext);
    }

    public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();

    public void Dispose()
    {
      _dbContext.Dispose();
    }

    public async Task ResetDatabaseAsync()
    {
      await _dbContext.Database.EnsureDeletedAsync();
      await _dbContext.Database.EnsureCreatedAsync();

      
    }
  }
}
