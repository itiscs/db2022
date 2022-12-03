using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsForDB.Models
{
    public class Task1
    {
        public string Name { get; set; }
        public DateTime Orderdate { get; set; }
        public int? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
    }       
}
