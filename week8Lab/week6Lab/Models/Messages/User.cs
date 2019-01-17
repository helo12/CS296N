using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models.Messages
{
	public class User
	{
		[Key]
		public int UserKey { get; set; }
		
		public string Fname { get; set; }
		public string Lname { get; set; }
	}
}

