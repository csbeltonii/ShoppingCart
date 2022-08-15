using Microsoft.EntityFrameworkCore.Infrastructure;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Models
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        public decimal Total
        {
            get
            {
                return OrderLineItems.Sum(item => item.Price * item.Quantity);
            }
        }

        public IEnumerable<OrderLineItem> OrderLineItems { get; set; }

        public OrderViewModel() { }

        public OrderViewModel(string customerId)
        {
            CustomerId = customerId;
            OrderLineItems = new List<OrderLineItem>();
        }

        public OrderViewModel(string customerId, 
                              IEnumerable<OrderLineItem> orderLineItems)
        {
            CustomerId = customerId;
            OrderLineItems = orderLineItems;
        }

        public OrderViewModel(string orderId, string customerId, string customerName, IEnumerable<OrderLineItem> orderLineItems)
        {
            OrderId = orderId;
            CustomerId = customerId;
            CustomerName = customerName;
            OrderLineItems = orderLineItems;
        }
    }
}
