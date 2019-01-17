using week6Lab.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace week6Lab.Models.Messages
{
	public interface IMessageRepo
	{
        List<Message> Sent { get; set; }
         List<Message> Received { get; set; }
        List<Message> Response { get; set; }
    }
}
