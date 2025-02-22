using System;
using System.Text.RegularExpressions;

namespace Security
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) return false;
            if (!Regex.IsMatch(password, @"[A-Z]")) return false;
            if (!Regex.IsMatch(password, @"\d")) return false;

            return true;
        }
    }
}

using NUnit.Framework;
using Security;

namespace SecurityTests
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [Test]
        [TestCase("Password1", ExpectedResult = true)] 
        [TestCase("Short1", ExpectedResult = false)]   
        [TestCase("nouppercase1", ExpectedResult = false)]
        [TestCase("NOLOWERCASE1", ExpectedResult = false)]
        [TestCase("NoNumbers!", ExpectedResult = false)] 
        [TestCase("Valid123Password", ExpectedResult = true)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]         public bool TestIsValidPassword(string password)
        {
            return _validator.IsValid(password);
        }
    }
}
