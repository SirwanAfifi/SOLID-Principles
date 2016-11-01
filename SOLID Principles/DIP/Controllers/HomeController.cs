using DIP.Core;
using Microsoft.AspNetCore.Mvc;

namespace DIP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(string notificationType)
        {
            INotifier notifier = null;

            switch (notificationType)
            {
                case "email":
                    notifier = new EmailNotifier();
                    break;
                case "sms":
                    notifier = new SMSNotifier();
                    break;
                case "popup":
                    notifier = new PopupNotifier();
                    break;
            }

            UserManager mgr = new UserManager(notifier);
            mgr.ChangePassword("user1", "oldpwd", "newpwd");
            return View("Success");
        }
    }
}
