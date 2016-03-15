using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public abstract class Ticket
    {
        public string Priority { get; set; }
        public ISender Sender { get; set; }
        public IReceiver Receiver { get; set; }


  
    }
}
