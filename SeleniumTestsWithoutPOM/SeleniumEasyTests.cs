using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    internal class SeleniumEasyTests
    {
        [Test]
        public void SingleInputFieldTest()
        {
            string expectedMessage = "Hellow World";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            var inputEnterMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input[@id='user-message']"));
            inputEnterMessage.SendKeys(expectedMessage);

            var buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            buttonShowMessage.Click();

            var spanMessage = driver.FindElement(By.XPath("//*[@id='get-input']/following-sibling::*/span"));
            string actualResult = spanMessage.Text;

            driver.Quit();

            Assert.AreEqual(expectedMessage, actualResult);
        }
    }
}
