using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Issue : Ticket, IClonable
    {
        public object Priority { get; private set; }

        public override void Resolve()
        {
            this.Priority = "Issue Resolved";

        }
        public IClonable Clone()
        {
            Issue newIssue = new Issue();
            newIssue.Priority = this.Priority;
            return newIssue;
        }
    }
}
