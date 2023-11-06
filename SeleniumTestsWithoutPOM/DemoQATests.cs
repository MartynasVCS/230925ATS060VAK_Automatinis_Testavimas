using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    internal class DemoQATests
    {
        [Test]
        public void TextBoxFormWithValidData()
        {
            string fullName = "Demo";
            string email = "demo@demo.com";
            string currentAddress = "Current address demo";
            string permanentAddress = "Permanent address demo";

            string expectedFullName = $"Name:{fullName}";
            string expectedEmail = $"Email:{email}";
            string expectedCurrentAddress = $"Current Address :{currentAddress}";
            string expectedPermanentAddress = $"Permananet Address :{permanentAddress}";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputFullName.SendKeys(fullName);
            inputEmail.SendKeys(email);
            inputCurrentAddress.SendKeys(currentAddress);
            inputPermanentAddress.SendKeys(permanentAddress);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 200);");
            buttonSubmit.Click();

            IWebElement paragraphFullName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement paragraphEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement paragraphCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement paragraphPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.AreEqual(expectedFullName, paragraphFullName.Text);
            Assert.AreEqual(expectedEmail, paragraphEmail.Text);
            Assert.AreEqual(expectedCurrentAddress, paragraphCurrentAddress.Text);
            Assert.AreEqual(expectedPermanentAddress, paragraphPermanentAddress.Text);
        }
    }
}
