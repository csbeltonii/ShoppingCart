namespace ShoppingCartExample.Models.Domain;

public class Customer
{
    public int Id { get; set; }
    public string UniqueIdentifier { get; set; }
    public string CustomerName { get; set; }
    public DateTime TimeCreated { get; set; }
    public DateTime LastModified { get; set; }

    public Customer() { }

    public Customer(int id, 
                    string uniqueIdentifier, 
                    string customerName)
    {
        Id = id;
        UniqueIdentifier = uniqueIdentifier;
        CustomerName = customerName;
    }
}