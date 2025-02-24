using NUnit.Framework;
using ExceptionHandlingApp;

namespace ExceptionHandlingTest
{
    [TestFixture]
    public class ExceptionHandlingTests
    {
        private ExceptionHandling _exceptionHandling;

        [SetUp]
        public void Setup()
        {
            _exceptionHandling = new ExceptionHandling();
        }

        [Test]
        public void Divide_ByZero_ShouldThrowArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => _exceptionHandling.Divide(10, 0));
        }

        [Test]
        public void Divide_ValidInputs_ShouldReturnCorrectQuotient()
        {
            int result = _exceptionHandling.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}