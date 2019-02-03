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

		public ViewResult Index() => View(roleManager.Roles);

		public IActionResult Create() => View();

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

		[Authorize(Roles = "admin")]
		[HttpPost]
		public async Task<IActionResult> Delete(string id)
		{
			IdentityRole role = await roleManager.FindByIdAsync(id);
			if (role != null)
			{
				IdentityResult result = await roleManager.DeleteAsync(role);
				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					AddErrorsFromResult(result);
				}
			}
			else
			{
				ModelState.AddModelError("", "No role found");
			}
			return View("Index", roleManager.Roles);
		}
		//[Authorize(Roles = "admin")]
		//public async Task<IActionResult> Edit(string id)
		//{

		//	IdentityRole role = await roleManager.FindByIdAsync(id);
		//	List<Customer> members = new List<Customer>();
		//	List<Customer> nonMembers = new List<Customer>();
		//	foreach (Customer user in userManager.Users)
		//	{
		//		var list = await userManager.IsInRoleAsync(user, role.Name)
		//			? members : nonMembers;
		//		list.Add(user);
		//	}
		//	return View(new RoleEditModel
		//	{
		//		Role = role,
		//		Members = members,
		//		NonMembers = nonMembers
		//	});
		//}
		private void AddErrorsFromResult(IdentityResult result)
		{
			foreach (IdentityError error in result.Errors)
			{
				ModelState.AddModelError("", error.Description);
			}
		}
	}
}