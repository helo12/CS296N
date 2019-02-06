using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models.Repos
{
	public interface ICustomerRepo
	{
		List<Customer> Customers { get; }
		void AddSent(Customer customer);
		void DeleteSent(Customer customer);
		void UpdateMessage(Customer customer);
		CustomerVM GetSentMessageByUser(string Name);
	}
}
