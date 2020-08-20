using NUnit.Framework;
using OnlinePOSLib;
using System;
using System.Linq;

namespace OnlinePOSNUnitTest
{
    public class EasterCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NextSunday()
        {
            var monday = new DateTime(2020, 8, 24);
            var nextSunday = monday.AddDays(6);            
            Assert.AreEqual(nextSunday, EasterCalculator.NextSunday(monday));
        }

        [Test]
        public void EasterHolidays2020()
        {
            DateTime[] holidays2020 = { new DateTime(2020, 4, 9), new DateTime(2020, 4, 10), new DateTime(2020, 4, 12), new DateTime(2020, 4, 13) };
            Assert.AreEqual(holidays2020, EasterCalculator.EasterHolidays("2020"));            
        }

          [Test]          
        public void EasterHolidaysException()
        {
            Assert.Throws<FormatException>(() => EasterCalculator.EasterHolidays("not a year"));            
        }
    }
}