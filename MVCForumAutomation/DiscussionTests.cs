using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationEssentials.MSTest;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    [TestClass]
    public class DiscussionTests : TestBase
    {
        private LandingPage LandingPage { get; set; }

        protected override void TestInitialize()
        {
            // TODO: create the specific browser according to configuration
            IWebDriver webDriver = new ChromeDriver();
            Browser browser = new Browser("MVCForum", webDriver, TestExecutionScopesManager);
            AddCleanupAction(() => browser.Dispose());
            LandingPage = new LandingPage(browser);
        }

        [TestMethod]
        public void DiscussionDetailsAreDisplayedAfterCreation()
        {
            LoggedInUser user = Login();
            CreateDiscussionPage createDiscussionPage = user.ClickCreateNewDiscussion();

            string title = "Dicussion Title by DummyUserName";
            string category = "Example Category";
            string description = "This is my first discussion";

            createDiscussionPage.Title = title;
            createDiscussionPage.Category = category;
            createDiscussionPage.Description = description;

            var discussionPage = createDiscussionPage.ClickCreateDiscussion();

            Assert.AreEqual(title, discussionPage.Title);
            Assert.AreEqual(category, discussionPage.Category);
            Assert.AreEqual(description, discussionPage.Description);
        }

        private LoggedInUser Login()
        {
            LogOnPage logOnPage = LandingPage.ClickLogOn();
            logOnPage.UserName = "Admin";
            logOnPage.Password = "password";
            logOnPage.ClickLogOnButton();
            return new LoggedInUser();
        }
    }
}