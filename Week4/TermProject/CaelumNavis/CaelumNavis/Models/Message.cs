using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class Message
	{
		public Customer cust { get; set; }

		public string MessageText { get; set; }
		public string Reason { get; set; }
		public bool bugOrError { get; set; }
		public int MessageID { get; set; }
		public DateTime TimeSent { get; set; }
		public Message()
		{
			cust = new Customer();
			Reason = "TestReason";
			MessageText = "This is a test Message";
			bugOrError = false;
		}
	}
	
}
