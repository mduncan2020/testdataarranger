using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace DomainUnderTest
{
    public class UserStory : WorkItemBase
    {
        public ICollection<Task> Tasks { get; set; }
        public bool IsDefect { get; set; }

        public UserStory()
        {
            this.Tasks = new List<Task>();
        }
    }
}
