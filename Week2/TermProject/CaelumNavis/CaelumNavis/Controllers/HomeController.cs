using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaelumNavis.Models;
using CaelumNavis.Models.Repos;

namespace CaelumNavis.Controllers
{
	public class HomeController : Controller
	{
		public ICustomerRepo CustomerRepo { get; set; }
		public IMessageRepo MessageRepo { get; set; }
		public HomeController(ICustomerRepo ICustRepo, IMessageRepo IMsgRepo)
		{
			this.MessageRepo = IMsgRepo;
			this.CustomerRepo = ICustRepo;

		}


		//home page
		public IActionResult Index()
		{

			return View();
		}
		//Frequently Asked Questions
		public IActionResult FAQ()
		{
			return View();
		}
		/*Message is a way for customers to contact us.
		Message form will load the form's view
		MessagePost will post a message to the DB 
		Message view will load a view but will not call the db 
		MessageGet will load a view with all the messages from the db. Search is not supported at this time
		*/
		public IActionResult MessageForm()
		{
			return View();
		}
		[HttpPost]
		public IActionResult MessagePost(string Name, string Email, string Reason, string Address, string City, string MessageText, bool BugOrError, bool CanContact, bool Terms)
		{
			if (ModelState.IsValid)
			{
				Message message = new Message();


				message.cust.Name = Name;
				message.cust.Email = Email;
				message.Reason = Reason;
				message.cust.Address = Address;
				message.cust.City = City;
				message.MessageText = MessageText;
				message.cust.Terms = Terms;
				message.bugOrError = BugOrError;
				message.cust.CanContact = CanContact;
				message.TimeSent = DateTime.Now;

				MessageRepo.AddSent(message);
				//ViewModel.repo.AddSent(ViewModel.Message);

				return View("MessageView", MessageRepo);
			}
			else
			{
				// there is a validation error
				return View();
			}
		}
		public IActionResult MessageView()
		{
			return View("MessageView", MessageRepo);

		}
		
		/*Pledge Form will load the form view so that the user can create a pledge
		 on button click the form will execute pledge post 
		 pledge view will load a vanilla view of all current pledges without contacting the db
		 pledge get will get all pledges from db searching is not supported at this time*/
		public IActionResult PledgeForm()
		{
			return View();
		}
		[HttpPost]
		public IActionResult PledgePost()
		{
			return View();
		}
		public IActionResult PledgeView()
		{
			return View();
		}
		[HttpGet]
		public IActionResult PledgeGet()
		{
			return View();
		}
		//RoadMap 
		public IActionResult RoadMap()
		{
			return View();
		}
		//Thank you screen which is displayed after submitting a form 
		public IActionResult Thankyou()
		{
			return View();
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		//Customer Crud Stuff
		public IActionResult CustomerView()
		{
			return View("CustomerView", CustomerRepo);
		}
		public IActionResult CreateCustomer() {
			return View();
		}

		[HttpPost]
		public IActionResult CreateCustomer(string Name, string Email, string Address, string City, string ZipCode, bool CanContact, bool Terms)
		{
		Customer cust = new Customer();
			cust.Name = Name;
			cust.Email = Email;
			cust.Address = Address;
			cust.City = City;
			cust.ZipCode = ZipCode;
			cust.CanContact = CanContact;
			cust.Terms = Terms;
			CustomerRepo.AddSent(cust);
			return View();
		}
		public IActionResult DeleteCustomer(string Name, string Email, string Address, string City, string ZipCode, bool CanContact, bool Terms)
	
		{
			Customer cust = new Customer();
			cust.Name = Name;
			cust.Email = Email;
			cust.Address = Address;
			cust.City = City;
			cust.ZipCode = ZipCode;
			cust.CanContact = CanContact;
			cust.Terms = Terms;
			CustomerRepo.DeleteSent(cust);
			return View();

		}
		[HttpPost]
		public IActionResult CustomerView(string searchString)
		{
			CustomerVM CustomerResult = CustomerRepo.GetSentMessageByUser(searchString);

			
			return View("Result", CustomerResult);
		}
		public IActionResult UpdateCustomer()
		{
			return View();
		}
	}

}
