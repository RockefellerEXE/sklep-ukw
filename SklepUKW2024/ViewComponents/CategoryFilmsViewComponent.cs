using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepUKW2024.DAL;

namespace SklepUKW2024.ViewComponents
{
	public class CategoryFilmsViewComponent : ViewComponent
	{
		FilmsContext db;

		public CategoryFilmsViewComponent(FilmsContext db)
		{
			this.db = db;
		}

		public async Task<IViewComponentResult> InvokeAsync(string categoryName)
		{
			var model = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single().Films.ToList();
			model = model.OrderBy(f => f.Title).ToList();

			return await Task.FromResult((IViewComponentResult)View("_CategoryFilms", model));
		}
	}
}
