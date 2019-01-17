using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week6Lab.Models.Repos;

namespace week6Lab.Models.Messages
{
	public class UserRepo: IUserRepo
	{
		public AppDBContext context;
		
		public List<User> Users { get { return context.DBUser.ToList<User>(); } }

		public void AddSent(User User)
		{
			this.context.DBUser.Add(User);
			this.context.SaveChanges();
		}

	}
}
