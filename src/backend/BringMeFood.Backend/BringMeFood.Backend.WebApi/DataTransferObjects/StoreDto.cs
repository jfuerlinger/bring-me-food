using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BringMeFood.Backend.WebApi.DataTransferObjects
{
  public class StoreDto : IDataTransferObject
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
