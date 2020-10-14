using BringMeFood.Backend.Core.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BringMeFood.Backend.Core.Model
{
  public class Store : IEntityObject
  {
    public int Id { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }

    public string Name { get; set; }

    public string Street { get; set; }

    [StringLength(5, MinimumLength = 4)]
    public string Postalcode { get; set; }
    public string City { get; set; }
    public string Phonenumber { get; set; }

    public ICollection<Order> Orders { get; set; }
  }
}
