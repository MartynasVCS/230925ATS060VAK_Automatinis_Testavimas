using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests : BaseTest
    {
        [Test]
        public void SingleInputField()
        {
            string expectedMessage = "Hellow World";

            BasicFirstFormDemo.Open();
            BasicFirstFormDemo.EnterMessage(expectedMessage);
            BasicFirstFormDemo.ClickButtonShowMessage();
            string actualMessage = BasicFirstFormDemo.GetMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
