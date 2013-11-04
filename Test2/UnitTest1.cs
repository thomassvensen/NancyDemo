using System;
using CsQuery.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy.Testing;
using NancyForIlan;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            var browser = new Browser(config => config.Module<HelloModule>());

            // act
            var response = browser.Get("/hus/43",
                with =>
                {
                    with.HttpRequest();
                    with.Header("accept", "application/json");
                });

            // assert
            Assert.AreEqual("[\"hus\",43]", response.Body.AsString());
        }
    }
}
