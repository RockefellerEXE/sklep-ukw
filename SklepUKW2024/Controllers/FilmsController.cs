using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using SklepUKW2024.DAL;
using SklepUKW2024.Models;

namespace SklepUKW2024.Controllers
{
	public class FilmsController : Controller
	{
		FilmsContext db;
		IWebHostEnvironment hostingEnvironment;

		public FilmsController(FilmsContext db, IWebHostEnvironment hostingEnvironment)
		{
			this.db = db;
			this.hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult FilmsList(string categoryName)
		{
			var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();

			var filmsFromCategory = category.Films.ToList();

			return View(filmsFromCategory);
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
		public IActionResult AddFilm(AddFilmViewModel model)
		{
			model.Film.AddDate = DateTime.Now;

			var picFolderPath = Path.Combine(hostingEnvironment.WebRootPath, "obrazki");
			var uniquePosterName = Guid.NewGuid() + "_" + model.Poster.FileName;
			model.Film.Poster = uniquePosterName;

			var fullPath = Path.Combine(picFolderPath, uniquePosterName);

			model.Poster.CopyTo(new FileStream(fullPath, FileMode.Create));

			db.Films.Add(model.Film);
			db.SaveChanges();

			//var film = db.Films.Find(model.Film.FilmId);

			return RedirectToAction("Details", new { filmId = model.Film.FilmId });
		}



		[HttpGet]
		public IActionResult EditFilm(int filmId)
		{
			var film = db.Films.Where(f => f.FilmId == filmId).FirstOrDefault();
			var category = db.Categories.Find(film.CategoryId);

			return View(film);
		}


		[HttpPost]
		public IActionResult EditFilm(Film model)
		{
			var film = db.Films.Where(f=>f.FilmId == model.FilmId).FirstOrDefault();

			film.Title = model.Title;
			film.Director = model.Director;
			film.Desc = model.Desc;
			film.Price = model.Price;

			db.Entry(film).State = EntityState.Modified;
			db.SaveChanges();

			return RedirectToAction("Details", new { filmId = model.FilmId });
		}

	}
}
