using System.Collections.Generic;

namespace LSP.Core
{
    public class GuestSettings : ISettings
    {
        public Dictionary<string, string> GetStrings()
        {
            var settings = new Dictionary<string, string> { {"GuestName", "John"} };
            return settings;
        }

        public string SetStrings(Dictionary<string, string> settings)
        {
            throw new System.NotImplementedException();
        }
    }
}