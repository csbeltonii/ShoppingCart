namespace ShoppingCartExample.Models
{
    public class CustomerListViewModel
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }

        public CustomerListViewModel() { }

        public CustomerListViewModel(IEnumerable<CustomerViewModel> customers)
        {
            Customers = customers;
        }
    }

    public class CustomerViewModel
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime LastModified { get; set; }

        public CustomerViewModel() { }

        public CustomerViewModel(string customerId, string customerName, DateTime timeCreated, DateTime lastModified)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            TimeCreated = timeCreated;
            LastModified = lastModified;
        }
    }
}
