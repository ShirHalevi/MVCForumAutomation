using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    internal class LogOnPage
    {
        private readonly Browser _browser;

        public LogOnPage(Browser browser)
        {
            _browser = browser;
        }

        public string UserName
        {
            get => throw new NotImplementedException();
            set
            {
                var userNameTextbox = _browser.WaitForElement(By.Id("UserName"), "Username textbox");
                userNameTextbox.Text = value;
            }
        }
        public string Password
        {
            get => throw new NotImplementedException();
            set
            {
                var passwordTextbox = _browser.WaitForElement(By.Id("Password"), "User password");
                passwordTextbox.Text = value;
            }
        }

        internal LoggedInUserShell ClickLogOnButton()
        {
            _browser.WaitForElement(By.ClassName("btn-mvc-green"), "log on button").Click();
            return new LoggedInUserShell(_browser);
        }
    }
}