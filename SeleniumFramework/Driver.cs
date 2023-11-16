using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumUndetectedChromeDriver;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        internal static string browser = TestContext.Parameters.Get("browser");

        public static void InitializeDriver(bool useUndetected = false)
        {
            switch (browser)
            {
                case "chrome":

                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--window-size=1920,1080");
                    
                    string headless = TestContext.Parameters.Get("headless");
                    if (headless == "true")
                    {
                        options.AddArgument("--headless");
                    }

                    if (useUndetected)
                    {
                        driver.Value = UndetectedChromeDriver.Create(driverExecutablePath: "C:\\Users\\Martynas\\Desktop\\chromedriver.exe");
                    }
                    else
                    {
                        driver.Value = new ChromeDriver(options);
                    }
                    break;
                case "firefox":
                    driver.Value = new FirefoxDriver();
                    break;
                default:
                    throw new Exception($"Value '{browser}' is not valid for 'browser' parameter");

            }
            
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

        public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}.png";
            
            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath);
            return screenshotFilePath;
        }
    }
}
