using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurilishKompaniyasi1.Models
{
   public  class Deficit
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string CompanyName { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

    }
}
