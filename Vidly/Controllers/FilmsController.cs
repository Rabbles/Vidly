using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public ActionResult Random()
        {
            var film = new Models.Film { Name = "A View To A Kill" };

            return View(film);
        }
        
        public ActionResult ByReleaseDate(int month, int year)
        {
            return Content($"{month}/{year}");
        }

    }
}