using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;

namespace BringMeFood.Backend.Persistence.Repositories
{
  class MealRepository : GenericRepository<Meal>, IMealRepository
  {
    public MealRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
  }
}
