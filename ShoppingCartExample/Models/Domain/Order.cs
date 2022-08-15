namespace ShoppingCartExample.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string UniqueIdentifier { get; set; }
        public string CustomerId { get; set; }
        public ICollection<OrderLineItem> OrderLineItems { get; set; }

        public decimal Total
        {
            get
            {
                return OrderLineItems.Sum(item => item.Price * item.Quantity);
            }
        }

        public bool IsFulfilled { get; set; }

        public DateTime TimeCreated { get; set; }
        public DateTime TimeModified { get; set; }

        public Customer Customer { get; set; }

        public Order() { }

        public Order(string uniqueIdentifier, 
                     string customerId, 
                     ICollection<OrderLineItem> orderLineItems, 
                     DateTime timeCreated, 
                     DateTime timeModified)
        {
            UniqueIdentifier = uniqueIdentifier;
            CustomerId = customerId;
            OrderLineItems = orderLineItems;
            TimeCreated = timeCreated;
            TimeModified = timeModified;
        }
    }
}
