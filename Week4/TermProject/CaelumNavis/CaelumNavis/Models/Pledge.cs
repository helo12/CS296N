using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class Pledge
	{
		public string CardNum {get; set;}
		public string ExpirationDate {get; set;}
		public string CVC {get; set;}
		public string Amount {get; set;}
		public string PledgeID {get; set;}
		public Customer customer {get; set;}
		public Pledge()
		{
			CardNum = "0000";
			ExpirationDate = "00/00/0000";
			CVC = "222";
			Amount = "0.00";
			customer = new Customer();
		}
	}
}
