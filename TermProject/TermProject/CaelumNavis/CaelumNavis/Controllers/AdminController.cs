using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaelumNavis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static CaelumNavis.Models.CustomerVM;
using CaelumNavis.Models.Repos;

namespace CaelumNavis.Controllers
{
	[Authorize(Roles = "Admins")]
	public class AdminController : Controller
	{


		private UserManager<Customer> userManager;
		private IUserValidator<Customer> userValidator;
		private IPasswordValidator<Customer> passwordValidator;
		private IPasswordHasher<Customer> passwordHasher;
        private IMessageRepo messageRepo;

		public AdminController(UserManager<Customer> usrMgr,
				IUserValidator<Customer> userValid,
				IPasswordValidator<Customer> passValid,
				IPasswordHasher<Customer> passwordHash,
                IMessageRepo messageRepo
                )
		{
			userManager = usrMgr;
			userValidator = userValid;
			passwordValidator = passValid;
			passwordHasher = passwordHash;
            this.messageRepo = messageRepo;
		}
		[Route("Admin/Index")]
		public ViewResult Index() => View(userManager.Users);
		[Route("Admin/CreatePage")]
		public ViewResult Create() => View();
		[Route("Admin/Delete")]
		public ViewResult Delete() => View();
	


[HttpPost]
[Route("Admin/Create")]
public async Task<IActionResult> Create(Models.CreateModel model)
{
	if (ModelState.IsValid)
	{
		Customer cust = new Customer
		{
			UserName = model.UserName,
			Email = model.Email
			
		};
		IdentityResult result
			= await userManager.CreateAsync(cust, model.Password);

		if (result.Succeeded)
		{
			return RedirectToAction("Index");
		}
		else
		{
			foreach (IdentityError error in result.Errors)
			{
				ModelState.AddModelError("", error.Description);
			}
		}
	}
	return View(model);
}

[HttpPost]
[Route("Admin/Delete")]
public async Task<IActionResult> Delete(string id)
{
	Customer user = await userManager.FindByIdAsync(id);
	if (user != null)
	{
				// Can't call delete user yet
				// Need to delete all messages in messageRepo that have that customer first
				// Need to delete any other data in repo that have that Customer
		messageRepo.DeleteMessagesByCustomer(user);
		IdentityResult result = await userManager.DeleteAsync(user);
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
		ModelState.AddModelError("", "User Not Found");
	}
	return View("Index", userManager.Users);
}

public async Task<IActionResult> Edit(string id)
{
	Customer user = await userManager.FindByIdAsync(id);
	if (user != null)
	{
		return View(user);
	}
	else
	{
		return RedirectToAction("Index");
	}
}

[HttpPost]
public async Task<IActionResult> Edit(string id, string email,
		string password)
{
	Customer user = await userManager.FindByIdAsync(id);
	if (user != null)
	{
		user.Email = email;
		IdentityResult validEmail
			= await userValidator.ValidateAsync(userManager, user);
		if (!validEmail.Succeeded)
		{
			AddErrorsFromResult(validEmail);
		}
		IdentityResult validPass = null;
		if (!string.IsNullOrEmpty(password))
		{
			validPass = await passwordValidator.ValidateAsync(userManager,
				user, password);
			if (validPass.Succeeded)
			{
				user.PasswordHash = passwordHasher.HashPassword(user,
					password);
			}
			else
			{
				AddErrorsFromResult(validPass);
			}
		}
		if ((validEmail.Succeeded && validPass == null)
				|| (validEmail.Succeeded
				&& password != string.Empty && validPass.Succeeded))
		{
			IdentityResult result = await userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			else
			{
				AddErrorsFromResult(result);
			}
		}
	}
	else
	{
		ModelState.AddModelError("", "User Not Found");
	}
	return View(user);
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