using System;

namespace Utilities
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrWhiteSpace(inputDate))
                throw new ArgumentException("Input date cannot be null or empty");

            if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");

            return parsedDate.ToString("dd-MM-yyyy");
        }
    }
}

using NUnit.Framework;
using Utilities;
using System;

namespace UtilitiesTests
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _formatter;

        [SetUp]
        public void Setup()
        {
            _formatter = new DateFormatter();
        }

        [Test]
        [TestCase("2025-02-22", ExpectedResult = "22-02-2025")] 
        [TestCase("2000-01-01", ExpectedResult = "01-01-2000")] 
        [TestCase("1999-12-31", ExpectedResult = "31-12-1999")] 
        public string TestValidFormatDate(string inputDate)
        {
            return _formatter.FormatDate(inputDate);
        }

        [Test]
        public void TestInvalidFormatDate_ShouldThrowFormatException()
        {
            Assert.Throws<FormatException>(() => _formatter.FormatDate("22-02-2025")); // Incorrect format
        }

        [Test]
        public void TestEmptyInput_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _formatter.FormatDate(""));
        }

        [Test]
        public void TestNullInput_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _formatter.FormatDate(null));
        }
    }
}
