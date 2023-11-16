using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class FramesTests : BaseTest
    {
        [Test]
        public void ReadIframeHeading()
        {
            string expectedHeading = "This is a sample page";

            Frames.Open();
            string actualHeading = Frames.GetFrameHeading();

            Assert.That(actualHeading, Is.EqualTo(expectedHeading));
        }
    }
}
