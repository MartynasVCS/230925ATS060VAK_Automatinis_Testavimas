using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestGoogle
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Driver.InitializeDriver(useUndetected: true);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string methodName = TestContext.CurrentContext.Test.MethodName;
                string filePath = Driver.TakeScreenshot(methodName);
                TestContext.AddTestAttachment(filePath);
            }

            Driver.QuitDriver();
        }
    }
}
