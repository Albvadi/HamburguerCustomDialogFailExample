using HamburguerConMvvm.Models;

namespace HamburguerConMvvm.ViewModels
{
    public class PrivateViewModel
    {
        public Customer Customer { get; set; }

        public PrivateViewModel(Customer myCustomer)
        {
            Customer = myCustomer;
        }
    }
}
