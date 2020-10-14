using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BringMeFood.Backend.WebApi.DataTransferObjects
{
  public class MealDto : IDataTransferObject
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
