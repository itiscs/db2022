using System;
using System.Collections.Generic;

namespace WinFormsApp8.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Edizm { get; set; }

    public decimal? Price { get; set; }

    public int? Count { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
