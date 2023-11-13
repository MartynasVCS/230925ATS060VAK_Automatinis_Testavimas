using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            DynamicProperties.Open();
        }

        [Test]
        public void ButtonBecomesEnabled()
        {
            DynamicProperties.WaitForFirstButtonToBeEnabled();
            bool buttonEnabled = DynamicProperties.GetFirstButtonEnabledStatus();

            Assert.That(buttonEnabled, Is.True);
        }

        [Test]
        public void ButtonTextColorChangesToRed()
        {
            string expectedButtonTextColor = "rgba(220, 53, 69, 1)";
            
            DynamicProperties.WaitForSecondButtonTextColorToBe(expectedButtonTextColor);
            string actualButtonTextColor = DynamicProperties.GetSecondButtonTextColor();

            Assert.That(actualButtonTextColor, Is.EqualTo(expectedButtonTextColor));
        }
    }
}
