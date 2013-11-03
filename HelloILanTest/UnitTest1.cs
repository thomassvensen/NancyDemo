using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy.Testing;
using NancyForIlan;

namespace HelloILanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var browser = new Browser(c => c.Module<HelloModule>());

            // act
            var response = browser.Get("/hus/43", with =>
            {
                with.HttpRequest();
                with.Header("accept", "application/json");
            });

            // assert
            Assert.AreEqual("[\"hus\",\"43\"]", response.Body.AsString());

        }
    }
}
