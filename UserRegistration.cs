using System;
using System.Text.RegularExpressions;

namespace UserManagement
{
    public class UserRegistration
    {
        public bool RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be empty");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format");

            if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"\d"))
                throw new ArgumentException("Password must be at least 8 characters long, contain one uppercase letter, and one digit");

            return true;
        }
    }
}

using NUnit.Framework;
using UserManagement;
using System;

namespace UserManagementTests
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _registration;

        [SetUp]
        public void Setup()
        {
            _registration = new UserRegistration();
        }

        [Test]
        [TestCase("JohnDoe", "john@example.com", "Password1", ExpectedResult = true)]
        [TestCase("Alice", "alice@example.com", "Secure123", ExpectedResult = true)]  
        public bool TestValidUserRegistration(string username, string email, string password)
        {
            return _registration.RegisterUser(username, email, password);
        }

        [Test]
        public void TestEmptyUsername_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("", "test@example.com", "Password1"));
        }

        [Test]
        public void TestInvalidEmail_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "invalid-email", "Password1"));
        }

        [Test]
        public void TestWeakPassword_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "weak"));
        }

        [Test]
        public void TestPasswordWithoutUppercase_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "password1"));
        }

        [Test]
        public void TestPasswordWithoutDigit_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "Password"));
        }
    }
}
