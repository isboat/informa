using NUnit.Framework;

namespace Informa.FizzBuzz.UnitTests.FizzBuzzServiceTests
{
    [TestFixture]
    public class ModFifteenTests: TestServiceBase
    {
        [Test]
        [TestCase(-5)]
        [TestCase(-2)]
        [TestCase(1)]
        [TestCase(6)]
        [TestCase(14)]
        [TestCase(16)]
        [TestCase(25)]
        public void NonModFifteenNumber(int input)
        {
            Assert.IsFalse(this._service.IsModFifteen(input));
        }

        [Test]
        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        public void ModFifteenNumber(int input)
        {
            Assert.IsTrue(this._service.IsModFifteen(input));
        }
    }
}