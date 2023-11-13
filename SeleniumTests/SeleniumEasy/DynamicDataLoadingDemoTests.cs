using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTests : BaseTest
    {
        [Test]
        public void PrintRandomUserNameAndSurname()
        {
            DynamicDataLoadingDemo.Open();
            DynamicDataLoadingDemo.ClickButtonGetNewUser();
            string userInfo = DynamicDataLoadingDemo.GetUserInfo();

            Console.WriteLine(userInfo);
        }
    }
}
