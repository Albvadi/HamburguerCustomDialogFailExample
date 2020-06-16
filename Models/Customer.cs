using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguerConMvvm.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Customer()
        {
            this.Name = "Customer 1";
            this.Age = 18;
        }

    }
}
