using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainUnderTest
{
    public abstract class WorkItemBase :IWorkItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
