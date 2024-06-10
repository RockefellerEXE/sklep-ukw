﻿using Microsoft.AspNetCore.Identity;

namespace SklepUKW2024.Models
{
	public class AppUser : IdentityUser<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
