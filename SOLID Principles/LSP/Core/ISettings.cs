﻿using System.Collections.Generic;

namespace LSP.Core
{
    public interface ISettings
    {
        Dictionary<string, string> GetSettings();
        string SetSettings(Dictionary<string, string> settings);
    }
}