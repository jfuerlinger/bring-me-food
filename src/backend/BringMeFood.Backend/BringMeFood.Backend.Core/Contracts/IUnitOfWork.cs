using System;
using System.Threading.Tasks;

namespace BringMeFood.Backend.Core.Contracts
{
  public interface IUnitOfWork : IDisposable
  {
    IMealRepository MealRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IOrderRepository OrderRepository { get; }
    IStoreRepository StoreRepository { get; }

    Task<int> SaveAsync();

    Task ResetDatabaseAsync();
  }
}
