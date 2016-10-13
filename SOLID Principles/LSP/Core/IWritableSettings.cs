using System.Collections.Generic;

namespace LSP.Core
{
    public interface IWritableSettings
    {
        string SetSettings(Dictionary<string, string> settings);
    }
}