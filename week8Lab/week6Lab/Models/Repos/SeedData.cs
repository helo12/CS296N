using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week6Lab.Models.Messages;

namespace week6Lab.Models.Repos
{
	public class SeedData
	{


		public User user1 = new User() { Fname = "test1", Lname = "test2" };
		public User user2 = new User() { Fname = "test1", Lname = "test2" };

		public Message Message1 = new Message() { Msg = "This is a test message and a bunch of null stuff" };
		public Message Message2 = new Message() { Msg = "This is a test message with less null stuff", Subject = "NullStuff", Priority = true };

		public UserRepo TestUserRepo = new UserRepo();
		public MessageRepo MessageRepo1 = new MessageRepo();

	}
}
