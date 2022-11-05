using System;
using System.Collections.Generic;

namespace DbClientApp.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? EdIzm { get; set; }
        public decimal? Price { get; set; }
        public int? Count { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
