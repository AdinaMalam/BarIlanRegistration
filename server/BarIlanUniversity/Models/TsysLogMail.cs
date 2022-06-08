using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TsysLogMail
    {
        public int ILogId { get; set; }
        public string? NvException { get; set; }
        public string? NvFunction { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
