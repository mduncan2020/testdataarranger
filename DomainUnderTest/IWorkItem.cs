using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainUnderTest
{
    interface IWorkItem
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}
