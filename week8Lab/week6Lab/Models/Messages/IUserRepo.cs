using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models.Messages
{
	public interface IUserRepo
	{
		 List<User> Users { get; }
	}
}
