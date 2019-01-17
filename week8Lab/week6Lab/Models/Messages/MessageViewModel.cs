using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models.Messages
{
    public class MessageViewModel
    {
        public MessageRepo messageRepo;
        public Message message;
        public MessageViewModel()
        {
            message = new Message();
            messageRepo = new MessageRepo();
        }
    }
}
