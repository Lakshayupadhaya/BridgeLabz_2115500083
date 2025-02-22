using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn2
{
    public class StringMethods
    {
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn2
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringMethods stringMethods = new StringMethods();
            Console.WriteLine(stringMethods.Reverse("TestCase"));
            Console.WriteLine(stringMethods.IsPalindrome("TestCase"));
            Console.WriteLine(stringMethods.ToUpperCase("TestCase"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Qn2;
namespace ClassLibrary1
{
    [TestFixture]
    public class StringTests
    {
        private StringMethods str;

        [SetUp]
        public void Setup()
        {
            str = new StringMethods();
        }

        [Test]
        public void TestReverse()
        {
            Assert.That(str.Reverse("hello"), Is.EqualTo("olleh"));
            Assert.That(str.Reverse("abc"), Is.EqualTo("cba"));
            Assert.That(str.Reverse("A"), Is.EqualTo("A"));
        }

        [Test]
        public void TestIsPalindrome()
        {
            Assert.That(str.IsPalindrome("madam"), Is.True);
            Assert.That(str.IsPalindrome("racecar"), Is.True);
            Assert.That(str.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void TestToUpperCase()
        {
            Assert.That(str.ToUpperCase("hello"), Is.EqualTo("HELLO"));
            Assert.That(str.ToUpperCase("world"), Is.EqualTo("WORLD"));
            Assert.That(str.ToUpperCase("TeSt"), Is.EqualTo("TEST"));
        }
    }
}
