using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    internal class LoggedInUserShell
    {
        private readonly Browser _browser;

        public LoggedInUserShell(Browser browser)
        {
            _browser = browser;
        }

        internal CreateDiscussionPage ClickNewDiscussionButton()
        {
            _browser.WaitForElement(By.ClassName("createtopicbutton"), "New Discussion").Click();
            return new CreateDiscussionPage();
        }
    }
}