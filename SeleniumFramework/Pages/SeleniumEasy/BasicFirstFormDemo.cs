namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        }

        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='get-input']//input[@id='user-message']";
            Common.SendKeysToElement(locator, message);
        }

        public static void ClickButtonShowMessage()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);
        }

        public static string GetMessage()
        {
            string locator = "//*[@id='get-input']/following-sibling::*/span";
            return Common.GetElementText(locator);
        }
    }
}
