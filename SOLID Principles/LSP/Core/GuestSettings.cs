using System.Collections.Generic;

namespace LSP.Core
{
    public class GuestSettings : IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            var settings = new Dictionary<string, string> { {"GuestName", "John"} };
            return settings;
        }
    }
}