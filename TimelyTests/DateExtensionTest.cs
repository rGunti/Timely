using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimelyExtensions;

namespace TimelyTests
{
    [TestClass]
    public class DateExtensionTest
    {
        [TestMethod]
        public void CheckMonthJanuary()
        {
            Assert.AreEqual(new DateTime(2015, 1, 15), 15.January(2015));
        }

        [TestMethod]
        public void CheckShortMonthJanuary()
        {
            Assert.AreEqual(new DateTime(2015, 1, 15), 15.Jan(2015));
        }

        [TestMethod]
        public void NullableYearTest()
        {
            Assert.AreEqual(new DateTime(DateTime.Now.Year, 10, 2), 2.October());
        }
    }
}
