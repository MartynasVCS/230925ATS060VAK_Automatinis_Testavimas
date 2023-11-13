namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/dynamic-properties");
        }

        public static void WaitForFirstButtonToBeEnabled()
        {
            Common.WaitForElementToBeEnabled(Locators.DynamicProperties.ButtonFirst);
        }

        public static bool GetFirstButtonEnabledStatus()
        {
            return Common.GetElementEnabledStatus(Locators.DynamicProperties.ButtonFirst);
        }

        public static void WaitForSecondButtonTextColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(Locators.DynamicProperties.ButtonSecond, "color", expectedColor);
        }

        public static string GetSecondButtonTextColor()
        {
            return Common.GetElementCssPropertyValue(Locators.DynamicProperties.ButtonSecond, "color");
        }
    }
}
