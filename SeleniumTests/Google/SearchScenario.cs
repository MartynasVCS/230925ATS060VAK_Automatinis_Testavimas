using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Google;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Google
{
    internal class SearchScenario : BaseTest
    {
        [Test]
        public void SearchInGoogle()
        {
            // Arrange
            string expectedResult = "Hello World - „Google“ paieška";

            // Act
            SearchPage.Open();
            SearchPage.ClickButtonDeclineCookies();
            SearchPage.EnterSearchPhrase("Hello World");
            SearchPage.ClickButtonSearch();
            string actualResult = Driver.GetPageTitle();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
