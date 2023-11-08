namespace SeleniumFramework.Pages.Google
{
    public class SearchPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.google.com");
        }

        public static void ClickButtonDeclineCookies()
        {
            string locator = "//*[@id='W0wltc']";
            Common.ClickElement(locator);
        }

        public static void EnterSearchPhrase(string phrase)
        {
            string locator = "//*[@id='APjFqb']";
            Common.SendKeysToElement(locator, phrase);
        }

        public static void ClickButtonSearch()
        {
            string locator = "(//*[@name='btnK'])[2]";
            Common.ClickElement(locator);
        }
    }
}
