using ShoppingCartExample.Data;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Services
{
    public interface ICustomerService
    {
        Task<Customer?> GetCustomer(string id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> CreateNewCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer?> GetCustomer(string id) => await _customerRepository.Get(id).ConfigureAwait(false);

        public async Task<IEnumerable<Customer>> GetCustomers() => await _customerRepository.GetAll().ConfigureAwait(false);

        public async Task<Customer> CreateNewCustomer(Customer customer) =>
            await _customerRepository.Add(customer).ConfigureAwait(false);

        public void UpdateCustomer(Customer customer) => _customerRepository.Update(customer);

        public void DeleteCustomer(Customer customer) => _customerRepository.Delete(customer);
    }
}
