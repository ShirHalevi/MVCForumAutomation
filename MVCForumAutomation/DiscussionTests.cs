using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCForumAutomation
{
    [TestClass]
    public class DiscussionTests
    {
        private LandingPage LandingPage { get; set; } = new LandingPage();

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
            RegisterPage registerPage = LandingPage.GoToRegisrationPage();
            registerPage.UserName = "DummyUserName";
            registerPage.Password = "A123456";
            registerPage.Email = RandomGenerator.CreateRandomEmail();
            LoggedInUser user = registerPage.ClickOnRegisterButton();
            return user;
        }
    }
}