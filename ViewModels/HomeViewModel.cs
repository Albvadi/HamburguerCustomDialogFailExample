using HamburguerConMvvm.Base;
using HamburguerConMvvm.Models;
using System.Windows.Input;

namespace HamburguerConMvvm.ViewModels
{
    public class HomeViewModel : PropertyChangedViewModel
    {
        public Customer Customer { get; set; }

        public ICommand ChangeNameCmd { get; }

        public HomeViewModel(Customer myCustomer)
        {
            Customer = myCustomer;

            ChangeNameCmd = new RelayCommand(ChangeName);            
        }

        public void ChangeName(object obj)
        {
            Customer.Name = "Customer changed";
            Customer.Age = 99;

            RaisePropertyChanged(nameof(Customer));
        }
    }
}
