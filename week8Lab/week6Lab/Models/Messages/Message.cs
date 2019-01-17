using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

using week6Lab.Models.Messages;
using week6Lab.Models.Repos;

namespace week6Lab.Models
{
	public class Message
	{

		[Key]
		public int Key { get; set; }
		
		public User User { get; set; }
		
		public int UserKey { get; set; }

		public DateTime TimeSent { get; set; }

		public string Msg { get; set; }

		public string Subject { get; set; }

		public bool Priority { get; set; }

		public bool Reply { get; set; }

		public Message()
		{
			User = new User();
			this.Priority = false;
			this.TimeSent = DateTime.Now;
			this.Reply = false;
		}
	}
}
