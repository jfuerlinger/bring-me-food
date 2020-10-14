using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;

namespace BringMeFood.Backend.Persistence.Repositories
{
  class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
  {
    public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
  }
}
