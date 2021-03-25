using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().FirstOrDefault(c => c.Id == id);

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer> { new Customer { Name = "Dave", Id = 1 }, new Customer { Name = "Smickers", Id = 2 } };
        }
    }
}