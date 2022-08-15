using System.Security.AccessControl;

namespace ShoppingCartExample.Models
{
    public class OrderListViewModel
    {
        public IEnumerable<OrderViewModel> Orders { get; set; }

        public OrderListViewModel() { }

        public OrderListViewModel(IEnumerable<OrderViewModel> orders)
        {
            Orders = orders;
        }
    }
}
