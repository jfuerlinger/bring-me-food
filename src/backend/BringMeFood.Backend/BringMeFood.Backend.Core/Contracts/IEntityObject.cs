using System.ComponentModel.DataAnnotations;

namespace BringMeFood.Backend.Core.Contracts
{
  interface IEntityObject
  {
    int Id { get; set; }
    
    [Timestamp]
    byte[] RowVersion { get; set; }
  }
}
