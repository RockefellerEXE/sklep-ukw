using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepUKW.DAL;

namespace SklepUKW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
        }
        public IActionResult FilmsList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c =>c.Name.ToLower() == categoryName.ToLower()).Single();
            var filmsFromCatehory = category.Films.ToList();

            return View(filmsFromCatehory);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
