using System;
namespace MathOperations
{
    public class NumberUtils
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}

using NUnit.Framework;
using MathOperations;

namespace NumberUtilsTests
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils;

        [SetUp]
        public void Setup()
        {
            _numberUtils = new NumberUtils();
        }

        [TestCase(2, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool TestIsEven(int number)
        {
            return _numberUtils.IsEven(number);
        }
    }
}
