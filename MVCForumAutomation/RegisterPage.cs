using System;

namespace MVCForumAutomation
{
    internal class RegisterPage
    {
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public object Email { get; internal set; }

        internal LatestPage ClickOnRegisterButton()
        {
            throw new NotImplementedException();
        }
    }
}