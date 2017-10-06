using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DomainUnderTest
{
    public class Epic : WorkItemBase
    {
        public ICollection<Story> Stories { get; set; }

        public Epic() : this(null, null, null, null)
        {
            
        }

        public Epic(string title, string description, DateTime? start, DateTime? end)
        {
            Stories = new List<Story>();

            this.Title = title;
            this.Description = description;
            this.Start = start;
            this.End = end;
        }

        public int DefectCount
        {
            get { return this.Stories.Count(s => s.IsDefect == true); }
        }
    }
}
