using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tfile
    {
        public int IFileId { get; set; }
        public string NvFileName { get; set; } = null!;
        public string? NvDescription { get; set; }
        public string? NvFile { get; set; }
        public string? NvLink { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
