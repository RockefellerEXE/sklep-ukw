using Microsoft.AspNetCore.Mvc;
using SklepUKW2024.DAL;
using SklepUKW2024.Infrastructure;
using SklepUKW2024.Models;

namespace SklepUKW2024.ViewComponents
{
	public class MenuViewComponent : ViewComponent
	{
		FilmsContext db;

		public MenuViewComponent(FilmsContext db)
		{
			this.db = db;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			ViewBag.Quantity = CartMenager.GetCartQuantity(HttpContext.Session);
			var categories = db.Categories.ToList();
			return await Task.FromResult((IViewComponentResult)View("_Menu", categories));
		}
	}
}
