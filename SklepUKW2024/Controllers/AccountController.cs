using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SklepUKW2024.Models;

namespace SklepUKW2024.Controllers
{
	public class AccountController : Controller
	{
		UserManager<AppUser> _userManager { get; }
		SignInManager<AppUser> _signInManager { get; }
		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		public async Task<IActionResult> Register()
		{
			var user = await _userManager.FindByNameAsync("TestUser");
			if (user == null)
			{
				user = new AppUser()
				{
					UserName = "TestUser",
					Email = "testuser@test.com",
					FirstName = "Jan",
					LastName = "Kowalski"
				};
				var result = await _userManager.CreateAsync(user, "Test123!");
			}
			return View();
		}
		public async Task<IActionResult> Login()
		{
			var restult = await _signInManager.PasswordSignInAsync("TestUser", "Test123!", false, false);
			if (restult.Succeeded)
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				return RedirectToAction("Index","Cart");
			}
		}
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
