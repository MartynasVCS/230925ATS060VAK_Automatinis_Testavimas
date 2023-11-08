using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static string GetPageTitle()
        {
            return driver.Title;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
