using NuGet.Frameworks;
using NUnit.Framework;
using PracticePrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Tests
{
    [TestFixture()]
    public class DayOfWeekUsingSwitchTests
    {
        [Test()]
        public void GetDayTest()
        {
            var obj = new DayOfWeekUsingSwitch();
            string sunday = obj.GetDay(0);
            Assert.AreEqual("Sunday", sunday);
            string monday = obj.GetDay(1);
            Assert.AreEqual("Monday", monday);
            string tuesday = obj.GetDay(2);
            Assert.AreEqual("Tuesday", tuesday);
            string wednesday = obj.GetDay(3);
            Assert.AreEqual("Wednesday", wednesday);
            string thursday = obj.GetDay(4);
            Assert.AreEqual("Thursday", thursday);
            string friday = obj.GetDay(5);
            Assert.AreEqual("Friday", friday);
            string saturday = obj.GetDay(6);
            Assert.AreEqual("Saturday", saturday);
            //TODO: Write testcase to test all conditions possible for GetDay functions
        }
    }
}
