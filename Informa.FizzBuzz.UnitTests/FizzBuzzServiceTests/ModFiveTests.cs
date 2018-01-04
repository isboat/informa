using NUnit.Framework;

namespace Informa.FizzBuzz.UnitTests.FizzBuzzServiceTests
{
    [TestFixture]
    public class ModFiveTests: TestServiceBase
    {
        [Test]
        [TestCase(-2)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(11)]
        public void NonModFiveNumber(int input)
        {
            Assert.IsFalse(this._service.IsModFive(input));
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        public void ModFiveNumber(int input)
        {
            Assert.IsTrue(this._service.IsModFive(input));
        }
    }
}