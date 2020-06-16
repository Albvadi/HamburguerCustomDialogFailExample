using HamburguerConMvvm.Base;
using HamburguerConMvvm.Models;
using HamburguerConMvvm.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguerConMvvm.ViewModels
{
    public class MainViewModel : PropertyChangedViewModel
    {
        public Customer MyCustomer { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public PrivateViewModel PrivateVM { get; set; }

        public MainViewModel()
        {
            MyCustomer = new Customer();

            Debug.WriteLine($"Customer Name: {MyCustomer.Name}");
            Debug.WriteLine($"Customer Age: {MyCustomer.Age}");

            HomeVM = new HomeViewModel(MyCustomer);
            PrivateVM = new PrivateViewModel(MyCustomer);
        }

    }
}
