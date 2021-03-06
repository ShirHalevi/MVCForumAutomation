﻿using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace MVCForumAutomation
{
    public class DefaultShell
    {
        private readonly Browser _browser;

        public DefaultShell(Browser browser)
        {
            _browser = browser;
            // TODO: move URL to external configuration file
            _browser.NavigateToUrl("http://localhost:9666/");
        }

        internal LogOnPage ClickLogOn()
        {
            var logonMenu = _browser.WaitForElement(By.ClassName("autoId-login"), "LogOn Menu");
            logonMenu.Click();

            return new LogOnPage(_browser);
        }
    }
}