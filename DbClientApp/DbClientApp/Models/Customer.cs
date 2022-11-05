using System;
using System.Collections.Generic;

namespace DbClientApp.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? City { get; set; }
        public string? Address { get; set; }
        public decimal? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
