using System.Threading.Tasks;

namespace BringMeFood.Backend.Core.Contracts
{
  public interface IGenericRepository<T> where T : class
  {
    Task<T[]> GetAllEntriesAsync();

    Task AddAsync(T entry);
    Task AddRangeAsync(T[] entries);

    void Delete(T entry);
  }
}
