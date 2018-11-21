using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCForumAutomation
{
    [TestClass]
    public class DiscuttionTests
    {
        [TestMethod]
        public void CreateNewDiscussionByNewAdminUser()
        {
            /*
           Go To regisraation page // Landing Page
           Enter User details and click on Register //Register Page
           add a new discussion //Latest Page
           Verify the dicussion created and display also in Latest Page. //Discussion Page, Latest Page.
            */

            RegisterPage registerPage = LandingPage.GoToRegisrationPage();
            registerPage.UserName = "DummyUserName";
            registerPage.Password = "A123456";
            registerPage.Email = RandomGenerator.CreateRandomEmail();
            LatestPage latestPage = RegisterPage.ClickOnRegisterButton();
            CreateDiscussionPage createDiscussionPage = latestPage.ClickCreateNewDiscussion();

            string title = "Dicussion Title by DummyUserName";
            string category = "Example Category";
            string tag = "Dummy";
            string description = "This is my first discussion";

            createDiscussionPage.Title = title;
            createDiscussionPage.Category = category;
            createDiscussionPage.Tag = tag;
            createDiscussionPage.Description = description;

            var discussionPage = createDiscussionPage.CreateDiscussionButton();
            
            Assert.AreEqual(title, discussionPage.Title);
            Assert.AreEqual(category, discussionPage.Category);
            Assert.AreEqual(tag, discussionPage.Tag);
            Assert.AreEqual(description, discussionPage.Description);

            latestPage = discussionPage.GoToLatestPage(); // This click can be done from any class, not only DiscussionPage


            Assert.AreEqual(title, latestPage.LastDiscussionInfo().Title);
            Assert.AreEqual(category, latestPage.LastDiscussionInfo().LastDiscussion.Category);
            Assert.AreEqual(tag, latestPage.LastDiscussionInfo().LastDiscussion.Tag);
            Assert.AreEqual(description, latestPage.LastDiscussionInfo().LastDiscussion.Description);
        }
    }
}