namespace SeleniumFramework.Pages.DemoQA
{
    internal class Locators
    {
        internal class TextBox
        {
            internal static string InputFullName = "//*[@id='userName']";
            internal static string InputEmail = "//*[@id='userEmail']";
            internal static string InputCurrentAddress = "//*[@id='currentAddress']";
            internal static string InputPermanentAddress = "//*[@id='permanentAddress']";
            internal static string ButtonSubmit = "//*[@id='submit']";
            internal static string OutputFullName = "//*[@id='output']//*[@id='name']";
            internal static string OutputEmail = "//*[@id='output']//*[@id='email']";
            internal static string OutputCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
            internal static string OutputPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
        }

        internal class DynamicProperties
        {
            internal static string ButtonFirst = "//*[@id='enableAfter']";
            internal static string ButtonSecond = "//*[@id='colorChange']";
        }
    }
}
