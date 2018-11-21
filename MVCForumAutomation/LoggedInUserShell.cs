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
            throw new NotImplementedException();
        }
    }
}