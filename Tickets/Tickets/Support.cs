using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Support : Employee, IReceiver
    {
        public void ReceiveTicket(Ticket ticket)
        {
            ticket.Receiver = this;
        }

        public void ResolveTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
