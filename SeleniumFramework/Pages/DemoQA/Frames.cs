namespace SeleniumFramework.Pages.DemoQA
{
    public class Frames
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/frames");
        }

        public static string GetFrameHeading()
        {
            string locatorHeading = "(//*[@id='sampleHeading'])[1]";
            string locatorIframe = "//*[@id='frame1']";

            Common.SwitchToIFrameByLocator(locatorIframe);
            string heading = Common.GetElementText(locatorHeading);
            Common.SwitchToDefaultContent();

            return heading;
        }
    }
}
