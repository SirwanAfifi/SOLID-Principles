using System.Collections.Generic;

namespace LSP.Core
{
    public interface IReadableSettings
    {
        Dictionary<string, string> GetSettings();
    }
}