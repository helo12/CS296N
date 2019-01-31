using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CaelumNavis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CaelumNavis.Controllers
{

	[Authorize(Roles = "Admins")]
	public class RoleAdminController : Controller
	{
		private RoleManager<IdentityRole> roleManager;
		private UserManager<Customer> userManager;


		public IActionResult Index()
		{
			return View();
		}

		public RoleAdminController(RoleManager<IdentityRole> roleMgr,
								   UserManager<Customer> userMrg)
		{
			roleManager = roleMgr;
			userManager = userMrg;
		}

		[HttpPost]
		public async Task<IActionResult> Create([Required]string name)
		{
			if (ModelState.IsValid)
			{
				IdentityResult result
					= await roleManager.CreateAsync(new IdentityRole(name));
				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					AddErrorsFromResult(result);
				}
			}
			return View(name);
		}
		private void AddErrorsFromResult(IdentityResult result)
		{
			foreach (IdentityError error in result.Errors)
			{
				ModelState.AddModelError("", error.Description);
			}
		}
	}
}