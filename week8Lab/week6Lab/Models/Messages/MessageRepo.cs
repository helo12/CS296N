using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week6Lab.Models.Repos;

namespace week6Lab.Models.Messages
{
	public class MessageRepo : IMessageRepo
	{

		public AppDBContext context;
		public List<Message> Sent { get; set; }
        public List<Message> Received { get; set; }
		public List<Message> Response { get; set; }

		public List<Message> Messages { get { return context.DBMessage.ToList<Message>(); } }

		public void AddSent(Message message)
		{
			this.context.DBMessage.Add(message);
			this.context.SaveChanges();
		}

		public MessageRepo()
		{
			
            Sent = new List<Message>();
            Received = new List <Message>();
            Response = new List<Message>();
            AddTestData();
        }

		//public void AddSent(Message message)
		//{
		//	Sent.Add(message);
		//}
		public void AddReceived(Message message)
		{
			Received.Add(message);
		}
		public void AddResponse(Message response)
		{
			Response.Add(response);
		}
		public  Message GetSentMessageBySubject(string Subject)
		{
			Message subjectMessage = Sent.Find(b => b.Subject == Subject);
			return subjectMessage;
		}
		public  Message GetSentMessageByUser(string userFname)
		{
			Message userMessage = Sent.Find(b => b.User.Fname == userFname);
			return userMessage;
		}
		public  Message GetReceivedMessageBySubject(string Subject)
		{
			Message subjectMessage = Sent.Find(b => b.Subject == Subject);
			return subjectMessage;
		}
		public  Message GetReceivedMessageByUser(string userFname)
		{
			Message userMessage = Sent.Find(b => b.User.Fname == userFname);
			return userMessage;
		}
		public void AddTestData()
		{
			Message message = new Message()
			{
				Msg = "This is a test",
				Priority = true,
				Subject = "Test",
				Reply = true,
				TimeSent = DateTime.Now,
				User = new User() { Fname = "Test", Lname = "User" }
			};
			Message response = new Message()
            {
                Msg = "This is a test response",
                Priority = true,
                Subject = "Test response",
                Reply = true,
                TimeSent = DateTime.Now,
                User = new User() { Fname = "Test", Lname = "User" }
            };
            Sent.Add(message);
			Received.Add(message);
			Response.Add(response);
		}
	}
}

