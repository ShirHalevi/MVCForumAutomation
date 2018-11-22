using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    internal class DiscussionPage
    {
        private readonly Browser _browser;

        public DiscussionPage(Browser browser)
        {
            _browser = browser;
        }

        public string Title
        {
            get //not working yet
            {
                return _browser.WaitForElement(By.ClassName("topicheading"),"Title element").Text;  
            }
        }
        public string Category { get; internal set; }
        public string Tag { get; internal set; }
        public string Description { get; internal set; }
    }
}