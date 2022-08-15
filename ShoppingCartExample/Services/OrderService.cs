using ShoppingCartExample.Data;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Services
{
    public interface IOrderService
    {
        Task<Order?> GetOrder(string id);
        Task<List<Order>> GetAlLOrders();
        Task<Order> CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order?> GetOrder(string id) => await _orderRepository.Get(id).ConfigureAwait(false);

        public async Task<List<Order>> GetAlLOrders() => (await _orderRepository.GetAll().ConfigureAwait(false)).ToList();

        public async Task<Order> CreateOrder(Order order) => await _orderRepository.Add(order).ConfigureAwait(false);

        public void UpdateOrder(Order order) => _orderRepository.Update(order);

        public void DeleteOrder(Order order) => _orderRepository.Delete(order);
    }
}
