using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCForumAutomation
{
    [TestClass]
    public class DiscuttionTests
    {
        private LandingPage LandingPage { get; set; } = new LandingPage();

        [TestMethod]
        public void DiscussionDetailsAreDisplayedAfterCreation()
        {
            /*
           Login // Landing page
           add a new discussion with title X and body Y //Logged-in user
           Verify the dicussion is displayed with title X and body Y //Discussion Page
            */

            LoggedInUser user = Login();
            CreateDiscussionPage createDiscussionPage = user.ClickCreateNewDiscussion();

            string title = "Dicussion Title by DummyUserName";
            string category = "Example Category";
            //string tag = "Dummy";
            string description = "This is my first discussion";

            createDiscussionPage.Title = title;
            createDiscussionPage.Category = category;
            //createDiscussionPage.Tag = tag;
            createDiscussionPage.Description = description;

            var discussionPage = createDiscussionPage.ClickCreateDiscussion();

            Assert.AreEqual(title, discussionPage.Title);
            Assert.AreEqual(category, discussionPage.Category);
            //Assert.AreEqual(tag, discussionPage.Tag);
            Assert.AreEqual(description, discussionPage.Description);

            //latestPage = discussionPage.GoToLatestPage(); // This click can be done from any class, not only DiscussionPage


            //Assert.AreEqual(title, latestPage.LastDiscussionInfo().Title);
            //Assert.AreEqual(category, latestPage.LastDiscussionInfo().LastDiscussion.Category);
            //Assert.AreEqual(tag, latestPage.LastDiscussionInfo().LastDiscussion.Tag);
            //Assert.AreEqual(description, latestPage.LastDiscussionInfo().LastDiscussion.Description);
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