using Microsoft.AspNetCore.Mvc;
using ShoppingCartExample.Models;
using ShoppingCartExample.Models.Domain;
using ShoppingCartExample.Services;

namespace ShoppingCartExample.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customers = (await _customerService.GetCustomers())
                            .OrderByDescending(customer => customer.LastModified)
                            .Take(3)
                            .Select(customer => new CustomerViewModel(customer.UniqueIdentifier, 
                                                                      customer.CustomerName, 
                                                                      customer.TimeCreated, 
                                                                      customer.LastModified));

            var viewModel = new CustomerListViewModel(customers);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create() => View(new CreateCustomerViewModel());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomerViewModel newCustomer)
        {
            var customer = new Customer()
            {
                CustomerName = newCustomer.CustomerName,
                UniqueIdentifier = Guid.NewGuid().ToString(),
                TimeCreated = DateTime.Now,
                LastModified = DateTime.Now
            };

            await _customerService.CreateNewCustomer(customer);

            return RedirectToAction("Edit", new { customerId = customer.UniqueIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string customerId)
        {
            var customer = await _customerService.GetCustomer(customerId);

            var viewModel = new CustomerViewModel(
                customer.UniqueIdentifier,
                customer.CustomerName,
                customer.TimeCreated,
                customer.LastModified
            );

            return View(viewModel);
        }
    }
}
