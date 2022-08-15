using Microsoft.AspNetCore.Mvc;
using ShoppingCartExample.Models;
using ShoppingCartExample.Models.Domain;
using ShoppingCartExample.Services;
using static System.Guid;

namespace ShoppingCartExample.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var orders = (await _orderService.GetAlLOrders())
                .Select(order => new OrderViewModel(order.UniqueIdentifier, 
                                                    order.CustomerId, 
                                                    order.Customer.CustomerName, 
                                                    order.OrderLineItems));

            return View(new OrderListViewModel(orders));
        }

        [HttpPost]
        public async Task<IActionResult> Create(string customerId)
        {
            var order = new Order(
                NewGuid().ToString(),
                customerId,
                new List<OrderLineItem>(),
                DateTime.Now,
                DateTime.Now
            );

            var customerOrder = await _orderService.CreateOrder(order);

            return View("Edit", new OrderViewModel(customerOrder.CustomerId, customerOrder.OrderLineItems));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrderViewModel orderViewModel)
        {
            var order = await _orderService.GetOrder(orderViewModel.OrderId);

            order.OrderLineItems = orderViewModel.OrderLineItems.ToList();

            _orderService.UpdateOrder(order);

            return View("Edit", new OrderViewModel(order.CustomerId, order.OrderLineItems));
        }
    }
}
