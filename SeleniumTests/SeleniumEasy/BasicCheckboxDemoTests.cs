using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;
using System.Collections.Generic;

[assembly: LevelOfParallelism(2)]
namespace SeleniumTests.SeleniumEasy
{
    [Parallelizable(scope: ParallelScope.All)]
    internal class BasicCheckboxDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicCheckboxDemo.Open();
        }

        [Test]
        public void ButtonCheckAllChecksAllOptions()
        {
            BasicCheckboxDemo.ClickButtonCheckUncheckAll();
            List<bool> statusList = BasicCheckboxDemo.GetSelectedStatusForAllOptions();

            foreach(bool status in statusList)
            {
                Assert.That(status, Is.True);
            }
        }

        [Test]
        public void ButtonUncheckAllUnchecksAllOptions()
        {
            BasicCheckboxDemo.ClickButtonCheckUncheckAll();
            BasicCheckboxDemo.ClickButtonCheckUncheckAll();
            List<bool> statusList = BasicCheckboxDemo.GetSelectedStatusForAllOptions();

            foreach (bool status in statusList)
            {
                Assert.That(status, Is.False);
            }
        }

        [Test]
        public void ButtonTitleChangesWithLastOptionSelected()
        {
            string expectedButtonTitleCheck = "Check All";
            string expectedButtonTitleUncheck = "Uncheck All";

            BasicCheckboxDemo.ClickOptionByIndex(0);
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleCheck));
            BasicCheckboxDemo.ClickOptionByIndex(1);
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleCheck));
            BasicCheckboxDemo.ClickOptionByIndex(2);
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleCheck));
            BasicCheckboxDemo.ClickOptionByIndex(3);
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleUncheck));
        }

        [Test]
        public void ButtonTitleChangesWithSingleOptionDeselected()
        {
            string expectedButtonTitleCheck = "Check All";
            string expectedButtonTitleUncheck = "Uncheck All";

            BasicCheckboxDemo.ClickButtonCheckUncheckAll();
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleUncheck));
            BasicCheckboxDemo.ClickOptionByIndex(0);
            Assert.That(BasicCheckboxDemo.GetButtonCheckUncheckAllTitle(), Is.EqualTo(expectedButtonTitleCheck));
        }
    }
}
