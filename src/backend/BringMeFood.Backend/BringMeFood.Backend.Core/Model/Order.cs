using BringMeFood.Backend.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BringMeFood.Backend.Core.Model
{
  public class Order : IEntityObject
  {
    public int Id { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }

    public DateTime OrderedAt { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int MealId { get; set; }
    public Meal Meal { get; set; }

    public int StoreId { get; set; }
    public Store Store { get; set; }
  }
}
