using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepUKW.DAL;
using SklepUKW.Models;

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
        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);
            var category = db.Categories.Find(film.CategoryId);

            return View(film);
        }
        [HttpGet]
        public IActionResult AddFilm()
        {
            var model = new AddFilmViewModel();
            model.Categories = db.Categories.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddFilm(AddFilmViewModel model) {
            model.Film.AddDate = DateTime.Now;
            model.Film.Poster = "cube.jpg";

            db.Films.Add(model.Film);
            db.SaveChanges();

            return RedirectToAction("Details",new { filmId = model.Film.FilmId });
        }
    }
}
