using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaelumNavis.Models;
using CaelumNavis.Models.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace CaelumNavis.Controllers
{
	
	public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Account/Login.cshtml");
        }
		private UserManager<Customer> userManager;
		private SignInManager<Customer> signInManager;
	
	

		public AccountController(UserManager<Customer> userMgr,
				SignInManager<Customer> signinMgr)
		{
			userManager = userMgr;
			signInManager = signinMgr;
		}


		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}

		[HttpPost]
		[AllowAnonymous]	
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				Customer customer = await userManager.FindByEmailAsync(model.Email);
				if (customer != null)
				{
					await signInManager.SignOutAsync();
					var result = await signInManager.PasswordSignInAsync(customer, model.Password, false, false);
					
					if (result.Succeeded)
					{

						//return Redirect(returnUrl ?? "");
						return RedirectToAction("Index", "Home");
					}
				}
				ModelState.AddModelError(nameof(LoginViewModel.Email), "Invalid user or password");
			}
			return View(model);
		}
		[Authorize]
		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}