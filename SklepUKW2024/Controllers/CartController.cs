using Microsoft.AspNetCore.Mvc;
using SklepUKW2024.DAL;
using SklepUKW2024.Infrastructure;
using SklepUKW2024.Models;
using System.Dynamic;

namespace SklepUKW2024.Controllers
{
    public class CartController : Controller
	{
		FilmsContext db;

		public CartController(FilmsContext db)
		{
			this.db = db;
		}
		[Route("/koszyk")]
		public IActionResult Index()
		{
			var cart = CartMenager.GetCartItems(HttpContext.Session);
			double? sum = cart.Sum(item => item.Quantity * item.Film.Price);
			ViewBag.total = sum;

			return View(cart);
		}

		public IActionResult AddToCart(int filmId) 
		{
			CartMenager.AddToCart(HttpContext.Session, filmId, db);
			return RedirectToAction("Index");
		}
		public IActionResult Remove(int filmId)
		{
			var model = new ItemRemoveViewModel()
			{
				itemId = filmId,
				itemQuantity = CartMenager.RemoveFromCart(HttpContext.Session,filmId),
				cartValue = CartMenager.GetCartValue(HttpContext.Session)
			};
			return Json(model);
		}
		private int GetIndex(int filmId)
		{
			var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

			for (int i = 0; i < cart.Count; i++)
			{
				if (cart[i].Film.FilmId.Equals(filmId))
				{
					return i;
				}
			}

			return -1;
		}
		
	}
}
