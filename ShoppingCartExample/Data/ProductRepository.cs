using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Data.Interfaces;
using ShoppingCartExample.Models.Domain;
using static System.Guid;

namespace ShoppingCartExample.Data
{
    public interface IProductRepository : IRepository<Product> { }

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(Database db) : base(db) { }

        public override async Task<Product?> Get(string id) => await _db.Products.FirstOrDefaultAsync(product => product.UniqueIdentifier == id);
    }
}
