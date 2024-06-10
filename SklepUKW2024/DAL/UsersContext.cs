using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SklepUKW2024.Models;

namespace SklepUKW2024.DAL
{
	public class UsersContext : IdentityDbContext<AppUser, AppRole, int>
	{
		public UsersContext(DbContextOptions<UsersContext> options) : base(options)

		{
		}
	}
}
