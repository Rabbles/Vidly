using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _applicationDbContext;

        public CustomersController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            //Eager Loading - This Include() method prevents null exceptions on missing MembershipTypes
            var customers = _applicationDbContext.Customers.Include(c => c.MembershipType).ToList();
            //this line would cause an exception.
            //var customers = _applicationDbContext.Customers.ToList();
            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            _applicationDbContext.Dispose();
        }

        public ActionResult Details(int id)
        {
            var customer = _applicationDbContext.Customers.FirstOrDefault(c => c.Id == id);

            return customer == null ? HttpNotFound() : (ActionResult)View(customer);
        }
    }
}