using SklepUKW2024.DAL;
using SklepUKW2024.Models;

namespace SklepUKW2024.Infrastructure
{
	public static class CartMenager
	{
		public static List<CartItem> GetCartItems(ISession session)
		{
			var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, Consts.CartSessionKey);
			if (cart == null)
			{
				cart = new List<CartItem>();
			}
			return cart;
		}
		public static void AddToCart(ISession session, int filmId, FilmsContext db)
		{
			var cart = GetCartItems(session);

			var thisFilm = cart.Find(f=>f.Film.FilmId == filmId);
			if (thisFilm != null)
			{
				thisFilm.Quantity++;
			}
			else
			{
				var newCartItem = db.Films.Where(f => f.FilmId == filmId).FirstOrDefault();
				if(newCartItem != null)
				{
					var cartItem = new CartItem
					{
						Film = newCartItem,
						Quantity = 1,
						Value = newCartItem.Price
					};
					cart.Add(cartItem);
				}
			}
			SessionHelper.SetObjectAsJson(session, Consts.CartSessionKey, cart);
		}
		public static int RemoveFromCart(ISession session, int filmId)
		{
			var cart = GetCartItems(session);

			var thisFilm = cart.Find(i => i.Film.FilmId==filmId);
			int ilosc = 0;
			if (thisFilm == null)
			{
				return ilosc;
			}
			if (thisFilm.Quantity > 1)
			{
				thisFilm.Quantity--;
				ilosc=thisFilm.Quantity;
			}
			else
			{
				cart.Remove(thisFilm);
			}
			SessionHelper.SetObjectAsJson(session, Consts.CartSessionKey, cart);
			return ilosc;
		}
		public static int GetCartQuantity(ISession session)
		{
			var cart = GetCartItems(session);

			int count = cart.Sum(i =>i.Quantity);
			return count;
		}

		internal static double? GetCartValue(ISession session)
		{
			var cart = GetCartItems(session);

			var value = cart.Sum(i => i.Quantity * i.Value);

			return value;
		}
	}
}
