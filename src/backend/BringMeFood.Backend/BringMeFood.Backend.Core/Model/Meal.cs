using BringMeFood.Backend.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace BringMeFood.Backend.Core.Model
{
  public class Meal : IEntityObject
  {
    public int Id { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }
    
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
