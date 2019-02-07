using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{

	public class Customer : IdentityUser
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public bool CanContact { get; set; }
		public bool Terms { get; set; }
		

		public Customer()
		{
			Name="Blank";
			Email="Blank@gmail.com";
			Address="3946 Blank drive";
			City="Blank";
			ZipCode="97402";
			CanContact=false;
			Terms=false;
		}


	}

	public class CreateModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}

}
