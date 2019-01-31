using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class CustomerVM
	{
		public List<Customer> Customers { get; set; }
		public Customer Customer { get; set; }
		public class CreateModel
		{
			[Required]
			public string UserName { get; set; }
			[Required]
			public string Email { get; set; }
			[Required]
			public string Password { get; set; }
		}
	}
}
