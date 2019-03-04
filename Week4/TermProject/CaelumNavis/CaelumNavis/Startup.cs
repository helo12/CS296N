﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CaelumNavis.Models.Repos;
using CaelumNavis.Models;
using CaelumNavis.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CaelumNavis
{
	public class Startup
	{
		
		public Startup(IConfiguration configuration) =>
			Configuration = configuration;

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{

			
			services.AddTransient<IMessageRepo, MessageRepo>();
			services.AddTransient<ICustomerRepo, CustomerRepo>();
			services.AddTransient<IPasswordValidator<Customer>,
				CustPassValidator>();
			services.AddTransient<IUserValidator<Customer>,
				CustValidator>();

			services.AddDbContext<AppDBContext>(options =>
				options.UseSqlServer(
					Configuration["ConnectionStrings:DefaultConnection"]));

			services.AddIdentity<Customer, IdentityRole>(opts => {
				opts.User.RequireUniqueEmail = true;
			//	opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
				opts.Password.RequiredLength = 6;
				opts.Password.RequireNonAlphanumeric = false;
				opts.Password.RequireLowercase = false;
				opts.Password.RequireUppercase = false;
				opts.Password.RequireDigit = false;
			}).AddEntityFrameworkStores<AppDBContext>()
				.AddDefaultTokenProviders();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		
	}
		
public void Configure(IApplicationBuilder app)
		{
			app.Use(async (context, next) =>
			{
				//context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
				//await next();
				context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
				await next();
			});
			
			app.UseStatusCodePages();
			app.UseDeveloperExceptionPage();
			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Account}/{action=Index}");
			});
			//app.UseMvcWithDefaultRoute();

			AppDBContext.CreateAdminAccount(app.ApplicationServices,
				Configuration).Wait();
			
			

		}
	}
}