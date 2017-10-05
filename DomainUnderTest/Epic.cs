﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DomainUnderTest
{
    public class Epic : WorkItemBase
    {
        public ICollection<UserStory> Stories { get; set; }

        public Epic()
        {
            Stories = new List<UserStory>();
        }

        public int DefectCount
        {
            get { return this.Stories.Count(s => s.IsDefect == true); }
        }
    }
}