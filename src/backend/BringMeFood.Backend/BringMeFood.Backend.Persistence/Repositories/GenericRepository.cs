using BringMeFood.Backend.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BringMeFood.Backend.Persistence.Repositories
{
  abstract class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    private readonly ApplicationDbContext _dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<T[]> GetAllEntriesAsync()
      => await _dbContext.Set<T>()
            .ToArrayAsync();

    public async Task AddAsync(T entry)
      => await _dbContext.Set<T>()
            .AddAsync(entry);

    public async Task AddRangeAsync(T[] entries)
      => await _dbContext.Set<T>()
            .AddRangeAsync(entries);

    public void Delete(T entry) => _dbContext.Set<T>().Remove(entry);
  }
}
