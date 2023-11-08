﻿using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
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
    }
}
