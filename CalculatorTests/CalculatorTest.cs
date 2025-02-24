using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorProject;
using NUnit.Framework;

namespace CalculatorTests
{
    public class CalculatorTest
    {
        private Calculator calculator;
        
        [SetUp]
        public void SetUp() 
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddTest() 
        {
            //Calculator calc = new Calculator();
            Assert.That(calculator.Add(2,3), Is.Not.EqualTo(7), "Must not be same");  
        }
    }
}
