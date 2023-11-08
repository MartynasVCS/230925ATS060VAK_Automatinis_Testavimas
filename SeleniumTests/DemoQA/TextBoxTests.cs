using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests : BaseTest
    {
        [Test]
        public void TextBoxFormWithValidData()
        {
            string fullName = "Demo";
            string email = "demo@demo.com";
            string currentAddress = "Current address demo";
            string permanentAddress = "Permanent address demo";

            TextBox.Open();
            TextBox.EnterFullName(fullName);
            TextBox.EnterEmail(email);
            TextBox.EnterCurrentAddress(currentAddress);
            TextBox.EnterPermanentAddress(permanentAddress);
            TextBox.ClickButtonSubmit();

            Assert.That(TextBox.GetOutputFullName(), Is.EqualTo($"Name:{fullName}"));
            Assert.That(TextBox.GetOutputEmail(), Is.EqualTo($"Email:{email}"));
            Assert.That(TextBox.GetOutputCurrentAddress(), Is.EqualTo($"Current Address :{currentAddress}"));
            Assert.That(TextBox.GetOutputPermanentAddress(), Is.EqualTo($"Permananet Address :{permanentAddress}"));
        }

        [Test]
        public void TextBoxFormWithInvalidEmail()
        {
            string email = "invalid";
            string expectedClassValue = "field-error";
            string expectedBorderColor = "rgb(255, 0, 0)";

            TextBox.Open();
            TextBox.EnterEmail(email);
            TextBox.ClickButtonSubmit();
            string actualBorderColor = TextBox.GetEmailInputBorderColor();
            string actualClassValue = TextBox.GetEmailInputClassValue();

            Assert.That(actualBorderColor, Is.EqualTo(expectedBorderColor));
            Assert.That(actualClassValue.Contains(expectedClassValue));
        }
    }
}
