using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class RoleEditor
	{
			public IdentityRole Role { get; set; }
			public IEnumerable<Customer> CustomerRoles { get; set; }
			public IEnumerable<Customer> CustomerNoRoles { get; set; }
	}
}
