using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp;
using NUnit.Framework;
using NUnit;



namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            int expected = _calculator.Add(4, 3);
            Assert.That(7, Is.EqualTo(expected));
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int expected = _calculator.Subtract(4, 3);
            Assert.That(1, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int expected = _calculator.Multiply(4, 3);
            Assert.That(12, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int expected = _calculator.Divide(4, 2);
            Assert.That(2, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}