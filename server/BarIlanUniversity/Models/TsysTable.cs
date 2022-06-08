using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TsysTable
    {
        public TsysTable()
        {
            TsysTableRows = new HashSet<TsysTableRow>();
        }

        public int ISysTableId { get; set; }
        public string? NvSysTableNameEng { get; set; }
        public string? NvSysTableNameHeb { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }

        public virtual ICollection<TsysTableRow> TsysTableRows { get; set; }
    }
}
