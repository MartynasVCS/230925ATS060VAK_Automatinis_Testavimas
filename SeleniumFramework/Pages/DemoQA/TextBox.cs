using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string fullName)
        {
            Common.SendKeysToElement(Locators.TextBox.InputFullName, fullName);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeysToElement(Locators.TextBox.InputEmail, email);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            Common.SendKeysToElement(Locators.TextBox.InputCurrentAddress, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            Common.SendKeysToElement(Locators.TextBox.InputPermanentAddress, permanentAddress);
        }

        public static void ClickButtonSubmit()
        {
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, Locators.TextBox.ButtonSubmit);
            Common.ClickElement(Locators.TextBox.ButtonSubmit);
        }

        public static string GetOutputFullName()
        {
            return Common.GetElementText(Locators.TextBox.OutputFullName);
        }

        public static string GetOutputEmail()
        {
            return Common.GetElementText(Locators.TextBox.OutputEmail);
        }

        public static string GetOutputCurrentAddress()
        {
            return Common.GetElementText(Locators.TextBox.OutputCurrentAddress);
        }

        public static string GetOutputPermanentAddress()
        {
            return Common.GetElementText(Locators.TextBox.OutputPermanentAddress);
        }

        public static string GetEmailInputBorderColor()
        {
            System.Threading.Thread.Sleep(150);
            return Common.GetElementCssPropertyValue(Locators.TextBox.InputEmail, "border-color");
        }

        public static string GetEmailInputClassValue()
        {
            return Common.GetElementHtmlAttributeValue(Locators.TextBox.InputEmail, "class");
        }

        public static bool EmailOutputExists()
        {
            return Common.ElementExists(Locators.TextBox.OutputEmail);
        }
    }
}
