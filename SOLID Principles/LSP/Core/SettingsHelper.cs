using System.Collections.Generic;

namespace LSP.Core
{
    public class SettingsHelper
    {
        public static Dictionary<ISettings, Dictionary<string, string>>
            GetAllSettings(List<ISettings> items)
        {
            var allSettings = new Dictionary<ISettings, Dictionary<string, string>>();
            foreach (ISettings item in items)
            {
                allSettings.Add(item, item.GetStrings());
            }
            return allSettings;
        }

        public static List<string> SetAllSettings(List<ISettings> items, 
            List<Dictionary<string, string>> values)
        {
            var messages = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                messages.Add(items[i].SetStrings(values[i]));
            }
            return messages;
        }
    }
}