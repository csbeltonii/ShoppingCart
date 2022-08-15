namespace ShoppingCartExample.Models.Domain
{
    public class OrderLineItem
    {
        public int Id { get; set; }
        public string UniqueIdentifier { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public OrderLineItem() { }

        public OrderLineItem(string uniqueIdentifier, 
                             string name, 
                             decimal price, 
                             string description)
        {
            UniqueIdentifier = uniqueIdentifier;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
