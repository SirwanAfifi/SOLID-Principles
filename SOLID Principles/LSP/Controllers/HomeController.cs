using System.Collections.Generic;
using LSP.Core;
using Microsoft.AspNetCore.Mvc;

namespace LSP.Controllers
{
    public class HomeController : Controller
    {
        List<IReadableSettings> readableSettings = new List<IReadableSettings>();
        List<IWritableSettings> writableSettings = new List<IWritableSettings>();

        public HomeController()
        {
            GlobalSettings g = new GlobalSettings();
            SectionSettings s = new SectionSettings();
            UserSettings u = new UserSettings();
            GuestSettings gu = new GuestSettings();

            readableSettings.Add(g);
            readableSettings.Add(s);
            readableSettings.Add(u);
            readableSettings.Add(gu);

            writableSettings.Add(g);
            writableSettings.Add(s);
            writableSettings.Add(u);
        }

        public IActionResult Index()
        {
            var allSettings = SettingsHelper.GetAllSettings(readableSettings);
            return View(allSettings);
        }

        public IActionResult Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();

            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Them", "Winter");

            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");

            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Sirwan");

            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Saywan");

            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);

            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);

            return View(model);
        }
    }
}
