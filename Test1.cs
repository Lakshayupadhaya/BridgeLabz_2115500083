using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("1 + 2 = " + calc.Add(1, 2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test1;
namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [Test]
        public void TestAdd()
        {
            Assert.That(calc.Add(1, 2), Is.EqualTo(3));
        }
        [Test]
        public void TestSubtract()
        {
            Assert.That(calc.Subtract(5, 3), Is.EqualTo(2));
        }
        [Test] public void TestMultiply() { 
            Assert.That(calc.Multiply(2, 3), Is.EqualTo(6));
        }
        [Test]
        public void TestDivide()
        {
            try
            { 
                Assert.That(calc.Divide(6, 3), Is.EqualTo(2)); 
            }
            catch (DivideByZeroException)
            {
                Assert.Fail("Divide by zero exception");
            }
        }
    }
}
