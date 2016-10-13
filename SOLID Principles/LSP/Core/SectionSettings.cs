using System;
using System.Collections.Generic;

namespace LSP.Core
{
    public class SectionSettings : ISettings
    {
        public Dictionary<string, string> GetStrings()
        {
            var settings = new Dictionary<string, string>
            {
                {"Them", "Summer"}
            };
            return settings;
        }

        public string SetStrings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "Global settings saved on " + DateTime.Now;
        }
    }
}