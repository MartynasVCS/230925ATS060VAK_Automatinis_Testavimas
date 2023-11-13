namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class DynamicDataLoadingDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public static void ClickButtonGetNewUser()
        {
            string locatorButton = "//*[@id='save']";
            string locatorUserInfo = "//*[@id='loading']";
            Common.ClickElement(locatorButton);
            Common.WaitForElementToNotContainText(locatorUserInfo, "loading...");
        }

        public static string GetUserInfo()
        {
            string locator = "//*[@id='loading']";
            return Common.GetElementText(locator);
        }
    }
}
