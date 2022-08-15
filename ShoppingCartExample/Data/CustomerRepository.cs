using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Data.Interfaces;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Data
{
    public interface ICustomerRepository: IRepository<Customer> { }

    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Database db) : base(db) { }

        public override async Task<Customer?> Get(string id) =>
            await _db.Customers.FirstOrDefaultAsync(customer => customer.UniqueIdentifier == id);
    }
}
