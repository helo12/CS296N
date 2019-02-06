using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaelumNavis.Models.Repos;
namespace CaelumNavis.Models
{
	public class MessageVM
	{

		
		public Message Message { get; set; }
		public MessageRepo Repo { get; set; }
	
	}
}
