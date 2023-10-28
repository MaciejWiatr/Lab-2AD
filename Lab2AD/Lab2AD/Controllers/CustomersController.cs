using LibApp.Models;
using LibApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers
{
    public class CustomersController : Controller
    {

        public IActionResult Index()
        {
            var viewModel = new IndexCustomersViewModel
            {
                Customers = GetCustomers()
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var customer = GetCustomers().Single(c => c.Id == id);

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Stefan batory"},
                new Customer { Id = 2, Name = "Stefan dwatory"},
                new Customer { Id = 3, Name = "Stefan trzytory"}
            };

            return customers;
        }
    }
}
