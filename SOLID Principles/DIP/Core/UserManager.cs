using System;

namespace DIP.Core
{
    public class UserManager
    {
        private readonly INotifier _notifier;

        public UserManager(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void ChangePassword(string username, string oldpwd, string newpwd)
        {
            // change password here

            // Notify the user
            _notifier.Notify("Password was changed on " + DateTime.Now);
        }
    }
}