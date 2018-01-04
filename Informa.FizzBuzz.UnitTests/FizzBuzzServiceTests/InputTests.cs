using NUnit.Framework;

namespace Informa.FizzBuzz.UnitTests.FizzBuzzServiceTests
{
    [TestFixture]
    public class InputTests: TestServiceBase
    {
        [Test]
        public void TryParseInput_NoRange()
        {
            // Act
            var actual = this._service.ParseInput(string.Empty);

            // Assert
            Assert.IsNull(actual, "Parse empty string.");
        }

        [Test]
        public void TryParseInput_ZeroAllow()
        {
            // Act
            var actual = this._service.ParseInput("0-10");

            // Assert
            Assert.IsNotNull(actual, "Zero allow as a starting number.");
        }

        [Test]
        [TestCase("-5-10")]
        public void TryParseInput_NegativeNotAllow(string input)
        {
            // Act
            var actual = this._service.ParseInput(input);

            // Assert
            Assert.IsNull(actual, "Negative numbers are not allow.");
        }

        [Test]
        [TestCase("210")]
        public void TryParseInput_NoSeparator(string input)
        {
            // Act
            var actual = this._service.ParseInput(input);

            // Assert
            Assert.IsNull(actual, "Expected false for no separator.");
        }

        [Test]
        [TestCase("2.10")]
        [TestCase("2/10")]
        [TestCase("2,10")]
        [TestCase("2&10")]
        [TestCase("2|10")]
        public void TryParseInput_IncorrectSeparator(string input)
        {
            // Act
            var actual = this._service.ParseInput(input);

            // Assert
            Assert.IsNull(actual, "Expected false for incorrect separator.");
        }

        [Test]
        public void TryParseInput_NoStartNumber()
        {
            // Act
            var actual = this._service.ParseInput("-2");

            // Assert
            Assert.IsNull(actual, "Expected false for no start number.");
        }

        [Test]
        public void TryParseInput_NoEndNumber()
        {
            // Act
            var actual = this._service.ParseInput("1-");

            // Assert
            Assert.IsNull(actual, "Expected false for no end number.");
        }

        [Test]
        [TestCase("10-10")]
        [TestCase("10-6")]
        public void TryParseInput_StartNumber_Not_GreaterThan_EndNumber(string input)
        {
            // Act
            var actual = this._service.ParseInput(input);

            // Assert
            Assert.IsNull(actual, "Start number not greater than end number.");
        }

        [Test]
        [TestCase("10-11")]
        [TestCase("10-17")]
        public void TryParseInput_Valid_Input(string input)
        {
            // Arrange
            var split = input.Split('-');
            var start = split[0];
            var end = split[1];

            // Act
            var actual = this._service.ParseInput(input);

            // Assert
            Assert.IsNotNull(actual, "Expected a valid input.");
            Assert.AreEqual(start, actual.Start.ToString(), string.Format("Expected a start number to be {0}.", start));
            Assert.AreEqual(end, actual.End.ToString(), string.Format("Expected a end number to be {0}.", end));
        }
    }
}