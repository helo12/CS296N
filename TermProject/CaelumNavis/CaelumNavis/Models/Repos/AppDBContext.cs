﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CaelumNavis.Models.Repos
{
	public class AppDBContext : IdentityDbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public static async Task CreateAdminAccount(IServiceProvider serviceProvider,
		IConfiguration configuration)
		{

			//UserManager<Customer> userManager =
			//	serviceProvider.GetRequiredService<UserManager<Customer>>();
			//RoleManager<IdentityRole> roleManager =
			//	serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			string username = configuration["Data:AdminUser:Name"];
			string email = configuration["Data:AdminUser:Email"];
			string password = configuration["Data:AdminUser:Password"];
			string role = configuration["Data:AdminUser:Role"];

			//if (await userManager.FindByNameAsync(username) == null)
			//{
			//	if (await roleManager.FindByNameAsync(role) == null)
			//	{
			//		await roleManager.CreateAsync(new IdentityRole(role));
			//	}

			Customer user = new Customer
			{
				UserName = username,
				Email = email
			};

			//IdentityResult result = await userManager
			//	.CreateAsync(user, password);
			//		if (result.Succeeded)
			//		{
			//			await userManager.AddToRoleAsync(user, role);
			//		}
			//	}
			//}
		}
	}
}
