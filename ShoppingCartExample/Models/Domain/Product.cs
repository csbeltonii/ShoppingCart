namespace ShoppingCartExample.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string UniqueIdentifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime LastPurchased { get; set; }

        public DateTime TimeCreated { get; set; }
        public DateTime TimeModified { get; set; }

        public Product() { }

        public Product(int id, 
                       string uniqueIdentifier, 
                       string name, 
                       string description, 
                       decimal price,
                       DateTime lastPurchased, 
                       DateTime timeCreated, 
                       DateTime timeModified)
        {
            Id = id;
            UniqueIdentifier = uniqueIdentifier;
            Name = name;
            Price = price;
            Description = description;
            LastPurchased = lastPurchased;
            TimeCreated = timeCreated;
            TimeModified = timeModified;
        }
    }
}
