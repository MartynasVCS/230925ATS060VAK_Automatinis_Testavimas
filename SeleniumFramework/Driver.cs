using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeDriver()
        {
            driver.Value = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        internal static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static string GetPageTitle()
        {
            return driver.Value.Title;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }
    }
}
