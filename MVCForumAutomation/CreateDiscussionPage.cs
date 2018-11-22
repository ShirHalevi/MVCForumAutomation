using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    internal class CreateDiscussionPage
    {
        private readonly Browser _browser;

        public CreateDiscussionPage(Browser browser)
        {
            _browser = browser;
        }

        public string Title
        {
            get => throw new NotImplementedException();
            set
            {
                var titleTextbox = _browser.WaitForElement(By.Id("Name"),"Title text box");
                titleTextbox.Text = value;
            }
        }
        public string Category
        {
            get => throw new NotImplementedException();
            set
            {
                IWebElement selectCategoryElement= _browser.WaitForElement(By.Id("Category"), "select category");
                SelectElement selectCategory = new SelectElement(selectCategoryElement);
                selectCategory.SelectByText(value);
            }
        }

        // GIT TEST
        public string Description
        {
            get => throw new NotImplementedException();
            set
            {
                var bodyFrame = _browser.GetFrame(By.Id("Content_ifr"), "Body Frame");
                var body = bodyFrame.WaitForElement(By.Id("tinymce"), "Body of discussion");
                body.Text = value;
            }           
        }

        public DiscussionPage ClickCreateDiscussion()
        {       
                var createDiscussion = _browser.WaitForElement(By.Id("autoId-CreateDiscussionBtn"), "Create Discussion Button");
                createDiscussion.Click(); 
                return new DiscussionPage(_browser);
        }
    }
}