using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Models.Domain;
using ShoppingCartExample.Utility;

namespace ShoppingCartExample.Data
{
    public class Database : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public Database(DbContextOptions<Database> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                        .HasData(DefaultProducts.GetDefaultProducts());

            modelBuilder.Entity<Order>()
                        .HasAlternateKey(order => order.UniqueIdentifier);

            modelBuilder.Entity<Customer>()
                        .HasAlternateKey(customer => customer.UniqueIdentifier);

            modelBuilder.Entity<OrderLineItem>()
                        .HasAlternateKey(item => item.UniqueIdentifier);

            modelBuilder.Entity<Product>()
                        .HasAlternateKey(product => product.UniqueIdentifier);
        }
    }
}
