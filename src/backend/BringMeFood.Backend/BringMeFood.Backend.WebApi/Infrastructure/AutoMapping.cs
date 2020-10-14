using AutoMapper;
using BringMeFood.Backend.Core.Model;
using BringMeFood.Backend.WebApi.DataTransferObjects;

namespace BringMeFood.Backend.WebApi.Infrastructure
{
  public class AutoMapping : Profile
  {
    public AutoMapping()
    {
      CreateMap<Meal, MealDto>().ReverseMap();
      CreateMap<Store, StoreDto>().ReverseMap();
    }
  }
}
