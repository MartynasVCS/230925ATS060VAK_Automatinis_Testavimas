using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    public class GoogleTests
    {
        [Test]
        public void DemoTest()
        {
            // Arrange
            string expectedResult = "Hello World - „Google“ paieška";

            // Act
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";

            IWebElement buttonDeclineCookies = driver.FindElement(By.XPath("//*[@id='W0wltc']"));
            buttonDeclineCookies.Click();

            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@id='APjFqb']"));
            inputSearch.SendKeys("Hello World");

            IWebElement buttonSearch = driver.FindElement(By.XPath("(//*[@name='btnK'])[2]"));
            buttonSearch.Click();

            string actualResult = driver.Title;

            driver.Quit();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
