using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tyear
    {
        public int IYearId { get; set; }
        public int IEnglishName { get; set; }
        public string NvHebrewName { get; set; } = null!;
        public bool BIsbLockRateLocked { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
