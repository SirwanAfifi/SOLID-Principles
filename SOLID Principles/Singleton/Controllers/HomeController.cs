using Microsoft.AspNetCore.Mvc;
using Singleton.Core;

namespace Singleton.Controllers
{
    public class HomeController : Controller
    {
        // Note: Before running the application you need to create the SingletonDb database

        public IActionResult Index()
        {
            WebsiteMetadata metadata = WebsiteMetadata.GetInstance();
            return View("Index", metadata);
        }
    }
}
