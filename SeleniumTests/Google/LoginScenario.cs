using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Google;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Google
{
    internal class LoginScenario : BaseTestGoogle
    {
        [Test]
        public void LoginToGoogle()
        {
            LoginPage.Open();
            LoginPage.EnterEmail("ponas.automatonas@gmail.com");
            LoginPage.ClickButtonNextAfterEmail();
            LoginPage.EnterPassword("gaf0kna9jqg*eub@EVR");
            LoginPage.ClickButtonNextAfterPassword();
            Assert.That(Driver.GetPageTitle(), Is.EqualTo("Google Account"));
        }

        [Test]
        public void LogoutFromGoogle()
        {
            LoginPage.ClickProfileButton();
            LoginPage.ClickLogoutButton();
            Assert.That(Driver.GetPageTitle(), Is.EqualTo("Prisijungti – „Google“ paskyros"));
        }
    }
}
