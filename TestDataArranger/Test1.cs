using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainUnderTest;
using TestData;

namespace TestDataArranger
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Epic_defectCount_calculates_correctly()
        {
            using (Arranger<Epic> epicArranger = new Arranger<Epic>())
            {
                var epic = epicArranger.Create();
                using (Arranger<UserStory> storyArranger = new Arranger<UserStory>())
                {
                    epic.Stories.Add(storyArranger.Create());
                    epic.Stories.Add(storyArranger.Create());

                    var defect = new UserStory();
                    defect.IsDefect = true;
                    storyArranger.Create(defect);
                    epic.Stories.Add(defect);
                    var expected = 1;

                    var result = epic.DefectCount;

                    Assert.AreEqual(expected, result);
                }
            }
        }
    }
}
