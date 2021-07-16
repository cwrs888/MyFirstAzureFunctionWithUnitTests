using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureFunction;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var result = Function1.Run(TestFactory.HttpRequestFactory("name", "Piet"), new MyLogger()).Result;

                Assert.AreEqual($"Hello, Piet.", ((OkObjectResult)result).Value);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}