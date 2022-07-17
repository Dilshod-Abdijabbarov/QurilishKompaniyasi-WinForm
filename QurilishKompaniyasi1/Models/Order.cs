using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurilishKompaniyasi1.Models
{
    public  class Order
    {
        public int Orderid { get; set; }

        public DateTime OrderDate { get; set; }
        public int Customerid { get; set; }

        public int Employeid { get; set; }

        public Customer Customers { get; set; }
       
        public Employee Employees { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}
