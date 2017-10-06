using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainUnderTest;

namespace TestData
{
    public class EpicArranger : Arranger<Epic>
    {
        public Epic CreateDefault()
        {
            var defaultEpic = new Epic(
                "First Space Shuttle Flight", 
                "First orbital spaceflight of NASA's Space Shuttle program in the orbiter Columbia.", 
                new DateTime(1981, 4, 12), 
                new DateTime(1981, 4, 14));
            return base.Create(defaultEpic);
        }
    }
}
