using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; } // dd.mm.yyyy
        public DateTime ExpirationDate { get; set; } // dd.mm.yyyy
        public DateTime CreatedAt { get; set; } // dd.mm.yyyy hh:mm
        public int Quantity { get; set; }
        public Category Kateqoriya { get; set; }

        public Company Shirket { get; set; }
    }
}
