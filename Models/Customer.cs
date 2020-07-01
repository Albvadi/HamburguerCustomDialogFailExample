namespace HamburguerConMvvm.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Customer()
        {
            Name = "Empty Customer";
            Age = 0;
        }

    }
}
