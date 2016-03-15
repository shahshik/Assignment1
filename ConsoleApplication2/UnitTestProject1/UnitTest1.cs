using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class UnitTest1
    {

        private TestApiController apiController;
        [OneTimeSetUp]
        public void TestMethod1()
        {
            apiController = new TestApiController();
        }

        [Test]

        public void When_PersonList_IsFetched()
        {
            var response = apiController.GetPerson();
            Assert.Equals(response.StatusCode, HttpStatusCode.Found);
        }
    }
}
