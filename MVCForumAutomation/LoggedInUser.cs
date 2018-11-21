using System;

namespace MVCForumAutomation
{
    internal class LoggedInUser
    {
        private LoggedInUserShell _shell;

        public LoggedInUser(LoggedInUserShell shell)
        {
            _shell = shell;
        }

        internal CreateDiscussionPage CreateNewDiscussion()
        {
            return _shell.ClickNewDiscussionButton();
        }
    }
}