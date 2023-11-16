namespace SeleniumFramework.Pages.Google
{
    public class LoginPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://accounts.google.com/");
        }

        public static void EnterEmail(string email)
        {
            string locator = "//input[@type='email']";
            Common.SendKeysToElement(locator, email);
        }

        public static void ClickButtonNextAfterEmail()
        {
            string inputLocator = "//*[@id='identifierNext']//button";
            string viewLocator = "//*[@id='initialView']";
            Common.ClickElement(inputLocator);
            Common.WaitForElementHtmlAttributeToNotHaveValue(viewLocator, "aria-busy", "true");
        }

        public static void EnterPassword(string password)
        {
            string locator = "//input[@type='password']";
            Common.SendKeysToElement(locator, password);
        }

        public static void ClickButtonNextAfterPassword()
        {
            string buttonLocator = "//*[@id='passwordNext']//button";
            string bannerLocator = "//*[@id='gb']";
            Common.ClickElement(buttonLocator);
            Common.WaitForElementToBePresent(bannerLocator);
        }

        public static void ClickProfileButton()
        {
            string locator = "//*[contains(@aria-label,'Google Account:')]";
            Common.ClickElement(locator);
        }

        public static void ClickLogoutButton()
        {
            string locator = "//*[@data-et='10']/a";
            Common.SwitchToIFrameByName("account");
            Common.ClickElement(locator);
            Common.SwitchToDefaultContent();
        }
    }
}
