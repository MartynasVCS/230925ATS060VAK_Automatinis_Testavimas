using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickButtonCheckUncheckAll()
        {
            string locator = "//*[@id='check1']";
            Common.ClickElement(locator);
        }

        public static List<bool> GetSelectedStatusForAllOptions()
        {
            string locator = "//*[@class='cb1-element']";
            return Common.GetSelectedStatusForElements(locator);
        }

        public static void ClickOptionByIndex(int index)
        {
            string locator = "//*[@class='cb1-element']";
            Common.ClickElementByIndex(locator, index);
        }

        public static string GetButtonCheckUncheckAllTitle()
        {
            string locator = "//*[@id='check1']";
            return Common.GetElementHtmlAttributeValue(locator, "value");
        }
    }
}
