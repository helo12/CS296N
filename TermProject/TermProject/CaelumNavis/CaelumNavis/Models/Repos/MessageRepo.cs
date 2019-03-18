using CaelumNavis.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
public class MessageRepo : IMessageRepo
	{
		AppDBContext context;
		public List<Message> Sent
		{
			get { return this.context.Messages.ToList<Message>(); }
		}
		

		public MessageRepo(AppDBContext context)
		{
		 this.context = context;
		}

		public void AddSent(Message message)
		{
			this.context.Messages.Add(message);
			this.context.SaveChanges();
		}
		public void DeleteSent(Message message)
		{
			int id = 0;
			message.MessageID = id;

			Sent.Find((m) => {
				if (m.MessageID == id)
				{
					this.context.Messages.Remove(message);
					this.context.SaveChanges();
					return true;
				}
				return false;
			});


		}
		//TODO
		public void UpdateMessage(Message message)
		{
			int id = 0;
			message.MessageID = id;

			Sent.Find((m) => {
				if (m.MessageID == id)
				{
					m.cust = message.cust;
					m.MessageText = message.MessageText;
					m.Reason = message.Reason;
					m.bugOrError = message.bugOrError;
					m.TimeSent = message.TimeSent;
					this.context.Messages.Update(m);
					this.context.SaveChanges();
					return true;
				}
				return false;
			});
		}
		public Message GetSentMessageByUser(string Name)
		{
			Message userMessage = Sent.Find(b => b.cust.Name == Name);
			return userMessage;
		}
		
		public void AddTestData()
		{
			Message message = new Message()
			{
				MessageText = "This is a test",
				bugOrError = true,
				Reason = "Test",
				
				TimeSent = DateTime.Now,
				cust = new Customer() { Name = "Test"}
			};
			Message response = new Message()
			{
				MessageText = "This is a test",
				bugOrError = true,
				Reason = "Test",
				TimeSent = DateTime.Now,
				cust = new Customer() { Name = "Test" }
			};
			Sent.Add(message);
			Sent.Add(response);

		}
        public void DeleteMessagesByCustomer (Customer customer){
            bool madeChanges = false;
            this.Sent.Find((m) => {
                if(m.cust == customer){

                    this.Sent.Remove(m);
                    return true;
                }
                else{
                    return false;
                }

             });
            if (madeChanges)
            {
                this.context.SaveChanges();
            }
        }
	}
}

