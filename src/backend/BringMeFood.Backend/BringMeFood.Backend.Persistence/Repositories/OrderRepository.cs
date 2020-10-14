using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;

namespace BringMeFood.Backend.Persistence.Repositories
{
  class OrderRepository : GenericRepository<Order>, IOrderRepository
  {
    public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
  }
}
