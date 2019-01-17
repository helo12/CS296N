using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week6Lab.Models;
using week6Lab.Models.Messages;

namespace week6Lab.Controllers
{
	public class HomeController : Controller
	{
        MessageViewModel ViewModel = new MessageViewModel();
        public IActionResult Index()
        {


            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        
        [HttpGet]
        public IActionResult Contact()
        {
           
            return View(ViewModel);
        }
        
		[HttpPost]
		public IActionResult Contact(string From, string Subject, string Msg, bool isPriority)
		{
			if (ModelState.IsValid)
            {


				ViewModel.message = new Message();

				ViewModel.message.User.Fname = From;
				ViewModel.message.Subject = Subject;
				ViewModel.message.Msg = Msg;
				ViewModel.message.Priority = isPriority;

                ViewModel.messageRepo.Sent.Add(ViewModel.message);

				return View("Contact", ViewModel);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public IActionResult Respond(string From, string Subject, string Msg, bool isPriority)
            {
                if (ModelState.IsValid)
                {


                    ViewModel.message = new Message();

                    ViewModel.message.User.Fname = From;
                    ViewModel.message.Subject = Subject;
                    ViewModel.message.Msg = Msg;
                    ViewModel.message.Priority = isPriority;

                    ViewModel.messageRepo.Response.Add(ViewModel.message);

                    return View("Contact" , ViewModel);
                }
                else
                {
                    // there is a validation error
                    return View();
                }
            }
        

		
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
