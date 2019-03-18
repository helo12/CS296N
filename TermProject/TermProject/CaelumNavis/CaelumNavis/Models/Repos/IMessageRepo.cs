using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models.Repos
{
	public interface IMessageRepo
	{
		
		List<Message> Sent { get; }
		void AddSent(Message message);
		void DeleteSent(Message message);
		void UpdateMessage(Message message);
		Message GetSentMessageByUser(string Name);
		void DeleteMessagesByCustomer(Customer customer);
		void AddTestData();

	}
}
