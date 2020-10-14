using BringMeFood.Backend.Core.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BringMeFood.Backend.Core.Model
{
  public class Customer : IEntityObject
  {
    public int Id { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    [NotMapped]
    public string Fullname { get; set; }

    public string Street { get; set; }
    public string Postalcode { get; set; }
    public string City { get; set; }
    public string Phonenumber { get; set; }

    public ICollection<Order> Orders { get; set; }
  }
}
