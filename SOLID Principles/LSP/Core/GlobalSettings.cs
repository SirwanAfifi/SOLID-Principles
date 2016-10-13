using System;
using System.Collections.Generic;

namespace LSP.Core
{
    public class GlobalSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            var settings = new Dictionary<string, string>
            {
                {"Them", "Summer"}
            };
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "Global settings saved on " + DateTime.Now;
        }
    }
}