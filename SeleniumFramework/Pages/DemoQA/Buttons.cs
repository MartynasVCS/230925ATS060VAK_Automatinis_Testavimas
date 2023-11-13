namespace SeleniumFramework.Pages.DemoQA
{
    public class Buttons
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/buttons");
        }

        public static void DoubleClickButtonDoubleClickMe()
        {
            Common.DoubleClickElement(Locators.Buttons.ButtonDoubleClickMe);
        }

        public static string GetDoubleClickOutputText()
        {
            return Common.GetElementText(Locators.Buttons.OutputDoubleClick);
        }
    }
}
