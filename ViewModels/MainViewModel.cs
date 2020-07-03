using HamburguerConMvvm.Base;
using HamburguerConMvvm.Models;

namespace HamburguerConMvvm.ViewModels
{
    public class MainViewModel : PropertyChangedViewModel
    {
        public Customer MyCustomer { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public PrivateViewModel PrivateVM { get; set; }
        public DialogsViewModel DialogsVM { get; set; }

        public MainViewModel()
        {
            MyCustomer = new Customer();

            HomeVM = new HomeViewModel(MyCustomer);
            PrivateVM = new PrivateViewModel(MyCustomer);
            DialogsVM = new DialogsViewModel();
        }

    }
}
