using System;
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
			
			string username = configuration["Data:AdminUser:Name"];
			string email = configuration["Data:AdminUser:Email"];
			string password = configuration["Data:AdminUser:Password"];
			string role = configuration["Data:AdminUser:Role"];

			const string ADMIN = "Admin";
			const string MEMBER = "Member";

			

			Customer user = new Customer
			{
			
			UserName = username,
				Email = email
			};

		
		}
	}
}
