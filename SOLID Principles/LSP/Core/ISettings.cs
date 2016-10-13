using System.Collections.Generic;

namespace LSP.Core
{
    public interface ISettings
    {
        Dictionary<string, string> GetStrings();
        string SetStrings(Dictionary<string, string> settings);
    }
}