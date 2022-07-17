using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurilishKompaniyasi1.Models
{
    public class Customer
    {
        public int Customerid { get; set; }

        public string CustomerName { get; set; }

        public string  Address { get; set; }

        public string PhoneNummer { get; set; }
        public int Orderid { get; set; }

        public Order Orders { get; set; }

    }
}
