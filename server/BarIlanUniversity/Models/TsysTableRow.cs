using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TsysTableRow
    {
        public int ISysTableRowId { get; set; }
        public int? ISysTableId { get; set; }
        public string? NvValue { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }

        public virtual TsysTable? ISysTable { get; set; }
    }
}
