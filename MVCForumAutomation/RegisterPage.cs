using System;

namespace MVCForumAutomation
{
    internal class RegisterPage
    {
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string Email { get; internal set; }

        internal LoggedInUser ClickOnRegisterButton()
        {
            throw new NotImplementedException();
        }
    }
}