using Microsoft.AspNetCore.Mvc;
using SklepUKW2024.DAL;
using SklepUKW2024.Models;
using System.Diagnostics;

namespace SklepUKW2024.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, FilmsContext db)
		{
			_logger = logger;
			this.db = db;
		}

		public IActionResult Index()
        {
            var filmy = db.Films.ToList();
            return View(filmy);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[Route("Footer")]
        public IActionResult FooterSites(string name)
        {
            return View(name);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}