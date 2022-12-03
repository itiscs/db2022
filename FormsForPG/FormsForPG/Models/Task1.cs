using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsForPG.Models
{
    public class Task1
    {
        public string Name { get; set; }
        public DateOnly Orderdate { get; set; }
        public int? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
    }

}
