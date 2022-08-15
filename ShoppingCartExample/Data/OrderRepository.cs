using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Data.Interfaces;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Data
{
    public interface IOrderRepository : IRepository<Order> { }

    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(Database db) : base(db) { }

        public override async Task<Order?> Get(string id) => await _db.Orders.FirstOrDefaultAsync(order => order.UniqueIdentifier == id);
    }
}
