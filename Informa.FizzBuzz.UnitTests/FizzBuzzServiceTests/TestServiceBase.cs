using NUnit.Framework;

namespace Informa.FizzBuzz.UnitTests.FizzBuzzServiceTests
{
    public class TestServiceBase
    {

        #region Service under test

        protected FizzBuzzService _service;

        #endregion

        #region Setup

        [SetUp]
        public void Setup()
        {
            this._service = new FizzBuzzService();
        }

        #endregion
    }
}