using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tsetting
    {
        public int ISettingId { get; set; }
        public string NvSettingName { get; set; } = null!;
        public string? NvValue { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
