using HamburguerConMvvm.Base;
using HamburguerConMvvm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HamburguerConMvvm.ViewModels
{
    public class HomeViewModel : PropertyChangedViewModel
    {
        public Customer Customer { get; set; }

        public ICommand ChangeNameCmd { get { return _ChangeNameCmd; } }
        private readonly ICommand _ChangeNameCmd;

        //public HomeViewModel()
        //{
        //    Customer = new Customer() { Name="From Homeview", Age=40 };

        //    Debug.WriteLine($"[HOMEVIEW] Customer Name: {Customer.Name}");
        //    Debug.WriteLine($"[HOMEVIEW] Customer Age: {Customer.Age}");
        //}

        public HomeViewModel(Customer myCustomer)
        {
            Customer = myCustomer;

            Debug.WriteLine($"[HOMEVIEW] Customer Name: {Customer.Name}");
            Debug.WriteLine($"[HOMEVIEW] Customer Age: {Customer.Age}");

            _ChangeNameCmd = new RelayCommand(Add, CanAdd);
        }

        public void Add(object obj)
        {
            Customer.Name = "Cambiado con el botón";
            Customer.Age = 99;

            RaisePropertyChanged(nameof(Customer));

            //MessageBox.Show("Botón pulsado correctamente!");
        }

        public bool CanAdd(object obj)
        {
            return true;
        }


    }
}
