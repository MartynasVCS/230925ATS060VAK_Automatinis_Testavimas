using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Google;

namespace SeleniumTests.Google
{
    internal class SearchScenario
    {
        [Test]
        public void SearchInGoogle()
        {
            // Arrange
            string expectedResult = "Hello World - „Google“ paieška";

            // Act
            Driver.InitializeDriver();

            SearchPage.Open();
            SearchPage.ClickButtonDeclineCookies();
            SearchPage.EnterSearchPhrase("Hello World");
            SearchPage.ClickButtonSearch();
            string actualResult = Driver.GetPageTitle();

            Driver.QuitDriver();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
