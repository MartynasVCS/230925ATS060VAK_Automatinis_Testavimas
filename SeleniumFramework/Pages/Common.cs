using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void ClickElementByIndex(string locator, int index)
        {
            GetElements(locator)[index].Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ExecuteJavascript(string script, string locator)
        {
            IWebElement element = GetElement(locator);
            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript(script, element);
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            IWebElement element = GetElement(locator);
            return element.GetCssValue(propertyName);
        }

        internal static string GetElementHtmlAttributeValue(string locator, string attributeName)
        {
            IWebElement element = GetElement(locator);
            return element.GetAttribute(attributeName);
        }

        internal static List<bool> GetSelectedStatusForElements(string locator)
        {
            List<bool> statusList = new List<bool>();

            List<IWebElement> elements = GetElements(locator);
            foreach (IWebElement element in elements)
            {
                statusList.Add(element.Selected);
            }

            return statusList;
        }

        internal static bool ElementExists(string locator)
        {
            try
            {
                IWebElement element = GetElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
            wait.Until(d => d.FindElement(By.XPath(locator)).Enabled == true);
        }

        internal static bool GetElementEnabledStatus(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string propertyName, string expectedPropertyValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetCssValue(propertyName) == expectedPropertyValue);
        }

        internal static void WaitForElementToNotContainText(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => !d.FindElement(By.XPath(locator)).Text.Contains(text));
        }

        internal static void DoubleClickElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void WaitForElementHtmlAttributeToNotHaveValue(string locator, string attributeName, string attributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName) != attributeValue);
        }

        internal static void WaitForElementToBePresent(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }

        internal static void SwitchToIFrameByLocator(string locator)
        {
            IWebElement element = GetElement(locator);
            Driver.GetDriver().SwitchTo().Frame(element);
        }

        internal static void SwitchToIFrameByName(string name)
        {
            Driver.GetDriver().SwitchTo().Frame(name);
        }

        internal static void SwitchToDefaultContent()
        {
            Driver.GetDriver().SwitchTo().DefaultContent();
        }

        // Kitas būdas patikrinti ar elementas egzistuoja
        // Čia remiamės tuo, kad FindElements metodas grąžina tuščią sąrašą jei neranda elementų
        //internal static bool ElementExists(string locator)
        //{
        //    List<IWebElement> elements = GetElements(locator);
        //    return elements.Count != 0;
        //}
    }
}
