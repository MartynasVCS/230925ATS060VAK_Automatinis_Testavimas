using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Google;

namespace SeleniumTests.Google
{
    internal class SearchScenario
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            SearchPage.Open();
        }

        [Test]
        public void SearchInGoogle()
        {
            // Arrange
            string expectedResult = "Hello World - „Google“ paieška";

            // Act
            SearchPage.ClickButtonDeclineCookies();
            SearchPage.EnterSearchPhrase("Hello World");
            SearchPage.ClickButtonSearch();
            string actualResult = Driver.GetPageTitle();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
