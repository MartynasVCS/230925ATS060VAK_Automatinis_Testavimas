using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests : BaseTest
    {
        [Test]
        public void PerformDoubleClick()
        {
            string expectedOutputText = "You have done a double click";

            Buttons.Open();
            Buttons.DoubleClickButtonDoubleClickMe();
            string actualOutputText = Buttons.GetDoubleClickOutputText();

            Assert.That(actualOutputText, Is.EqualTo(expectedOutputText));
        }
    }
}
