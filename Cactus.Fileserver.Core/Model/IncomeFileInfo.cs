﻿using System.Collections.Generic;

namespace Cactus.Fileserver.Core.Model
{
    public class IncomeFileInfo : IFileInfo
    {
        public string MimeType { get; set; }
        public string OriginalName { get; set; }
        public string Owner { get; set; }
        public IDictionary<string, string> Extra { get; set; }
    }
}
