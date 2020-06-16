using HamburguerConMvvm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguerConMvvm.ViewModels
{
    public class PrivateViewModel
    {
        public Customer Customer { get; set; }

        public PrivateViewModel(Customer myCustomer)
        {
            Customer = myCustomer;

            Debug.WriteLine($"[PRIVATEVIEW] Customer Name: {Customer.Name}");
            Debug.WriteLine($"[PRIVATEVIEW] Customer Age: {Customer.Age}");
        }
    }
}
