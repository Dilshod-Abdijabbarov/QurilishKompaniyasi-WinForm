using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurilishKompaniyasi1.Models
{
    public  class Employee
    {
        [Key]
        public int Employeid { get; set; }

        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public string  Position { get; set; }

        public string Address { get; set; }

        public string PhoneNummer { get; set; }

        public DateTime StartWorking { get; set; }
        public int Orderid { get; set; }

        public Order Orders { get; set; }


    }
}
