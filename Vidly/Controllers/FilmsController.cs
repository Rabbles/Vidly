using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public ActionResult Random()
        {
            var film = new Film { Name = "A View To A Kill" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Smeagol"},
                new Customer{Name = "Sharkey"}
            };

            var viewModel = new RandomFilmViewModel
            {
                Film = film,
                Customers = customers
            };

            return View(viewModel);
        }
        
        //[Route("films/released/{year:regex(\\d{4})}/{month:regex(\\d{2}}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        public ViewResult Index()
        {
            return View(GetFilms());
        }

        private List<Film> GetFilms()
        {
            return new List<Film>
            {
                new Film { Id = 1, Name = "The Grand Budapest Hotel" },
                new Film { Id = 2, Name = "Mullholland Drive"},
                new Film { Id = 3, Name = "My Neighbour Totoro"}
            };
        }
    }
}