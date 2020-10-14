using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;

namespace BringMeFood.Backend.Persistence.Repositories
{
  class StoreRepository : GenericRepository<Store>, IStoreRepository
  {
    public StoreRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
  }
}
