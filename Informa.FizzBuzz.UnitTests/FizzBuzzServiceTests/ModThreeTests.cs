using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Informa.FizzBuzz.UnitTests.FizzBuzzServiceTests
{
    [TestFixture]
    public class ModThreeTests: TestServiceBase
    {
        [Test]
        [TestCase(-2)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(11)]
        public void NonModThreeNumber(int input)
        {
            Assert.IsFalse(this._service.IsModThree(input));
        }

        [Test]
        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(3)]
        [TestCase(6)]
        public void ModThreeNumber(int input)
        {
            Assert.IsTrue(this._service.IsModThree(input));
        }
    }
}