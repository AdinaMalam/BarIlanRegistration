using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TcontentTag
    {
        public int IContentTagId { get; set; }
        public string NvContentTagName { get; set; } = null!;
        public string NvDisplayName { get; set; } = null!;
        public string NvFieldDisplayName { get; set; } = null!;
    }
}
