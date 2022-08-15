using ShoppingCartExample.Models.Domain;
using static System.Guid;

namespace ShoppingCartExample.Utility
{
    public static class DefaultProducts
    {
        public static IEnumerable<Product> GetDefaultProducts() => new List<Product>
        {
            new(
                id: 1,
                uniqueIdentifier: NewGuid().ToString(),
                name: "Persephone",
                description: "IBANEZ RG655CBM (COBALT BLUE METALLIC)",
                price: 1599.99M,
                lastPurchased: DateTime.Parse("02/15/2016"),
                timeCreated: DateTime.Now,
                timeModified: DateTime.Now
            ),
            new(
                id: 2,
                uniqueIdentifier: NewGuid().ToString(),
                name: "Aphrodite",
                description: "FENDER STRATOCASTER STANDARD (ARCTIC WHITE)",
                price: 549.99M,
                lastPurchased: DateTime.Parse("03/29/2010"),
                timeCreated: DateTime.Now,
                timeModified: DateTime.Now
            ),
            new(
                id: 3,
                uniqueIdentifier: NewGuid().ToString(),
                name: "Ceres",
                description: "IBANEZ S1070PBZ (CERULEAN BLUE BURST)",
                price: 1866.99M,
                lastPurchased: DateTime.Parse("04/14/2022"),
                timeCreated: DateTime.Now,
                timeModified: DateTime.Now

            )
        };
    }
}
