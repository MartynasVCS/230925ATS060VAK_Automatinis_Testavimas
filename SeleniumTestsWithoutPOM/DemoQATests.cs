﻿using NUnit.Framework;
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

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", buttonSubmit);
            buttonSubmit.Click();
            
            IWebElement paragraphFullName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement paragraphEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement paragraphCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement paragraphPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.AreEqual(expectedFullName, paragraphFullName.Text);
            Assert.AreEqual(expectedEmail, paragraphEmail.Text);
            Assert.AreEqual(expectedCurrentAddress, paragraphCurrentAddress.Text);
            Assert.AreEqual(expectedPermanentAddress, paragraphPermanentAddress.Text);

            driver.Quit();
        }

        [Test]
        public void TextBoxFormWithInvalidEmail()
        {
            string email = "invalid";
            string expectedEmailInputClassAttributeValue = "field-error";
            string expectedBorderColor = "rgb(255, 0, 0)";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            // Patikriname, kad testo pradžioje email laukelyje nėra klaidos
            Assert.IsFalse(inputEmail.GetAttribute("class").Contains(expectedEmailInputClassAttributeValue));
            Assert.That(!inputEmail.GetAttribute("class").Contains(expectedEmailInputClassAttributeValue));
            StringAssert.DoesNotContain(expectedEmailInputClassAttributeValue, inputEmail.GetAttribute("class"));

            inputEmail.SendKeys(email);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", buttonSubmit);
            buttonSubmit.Click();

            System.Threading.Thread.Sleep(150);
            string actualBorderColor = inputEmail.GetCssValue("border-color");
            string actualEmailInputClassAttributeValue = inputEmail.GetAttribute("class");

            // Patikriname, kad email laukelyje yra klaida
            Assert.IsTrue(actualEmailInputClassAttributeValue.Contains(expectedEmailInputClassAttributeValue));
            Assert.That(actualEmailInputClassAttributeValue.Contains(expectedEmailInputClassAttributeValue));
            StringAssert.Contains(expectedEmailInputClassAttributeValue, actualEmailInputClassAttributeValue);
            Assert.That(actualBorderColor, Is.EqualTo(expectedBorderColor));

            driver.Quit();
        }
    }
}
