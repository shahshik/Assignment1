using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public interface IReceiver
    {
        void ReceiveTicket(Ticket ticket);
        void ResolveTicket(Ticket ticket);
    }
}
