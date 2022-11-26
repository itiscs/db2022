using System;
using System.Collections.Generic;

namespace WinFormsApp013.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? EdIzm { get; set; }

    public decimal? Price { get; set; }

    public int? Count { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
