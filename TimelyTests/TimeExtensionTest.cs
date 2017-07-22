using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimelyExtensions;

namespace TimelyTests
{
    [TestClass]
    public class TimeExtensionTest
    {
        [TestMethod]
        public void CheckTimeSpanContent()
        {
            Assert.AreEqual(TimeSpan.FromSeconds(49), 49.Seconds());
        }

        [TestMethod]
        public void CheckTimeSpanAddition()
        {
            TimeSpan expected = TimeSpan.FromSeconds(160);
            TimeSpan actual = 2.Minutes() + 40.Seconds();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTimeSpanSubtraction()
        {
            TimeSpan expected = TimeSpan.FromMinutes(97);
            TimeSpan actual = 2.Hours() - 23.Minutes();
            Assert.AreEqual(expected, actual);
        }
    }
}
