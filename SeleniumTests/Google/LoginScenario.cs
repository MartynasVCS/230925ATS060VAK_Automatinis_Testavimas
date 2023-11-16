using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Google;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Google
{
    internal class LoginScenario : BaseTestGoogle
    {
        [Test, Order(1)]
        public void LoginToGoogle()
        {
            LoginPage.Open();
            LoginPage.EnterEmail(TestContext.Parameters.Get("googleEmail"));
            LoginPage.ClickButtonNextAfterEmail();
            LoginPage.EnterPassword(TestContext.Parameters.Get("googlePassword"));
            LoginPage.ClickButtonNextAfterPassword();
            Assert.That(Driver.GetPageTitle(), Is.EqualTo("Google Account"));
        }

        [Test, Order(2)]
        public void LogoutFromGoogle()
        {
            LoginPage.ClickProfileButton();
            LoginPage.ClickLogoutButton();
            Assert.That(Driver.GetPageTitle(), Is.EqualTo("Prisijungti – „Google“ paskyros"));
        }
    }
}
