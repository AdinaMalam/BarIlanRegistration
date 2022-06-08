using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class ThistoryChange
    {
        public int IHistoryChangesId { get; set; }
        public int IInstitutionId { get; set; }
        public int? IFieldId { get; set; }
        public string? NvOldValue { get; set; }
        public string? NvNewValue { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }

        public virtual Tfield? IField { get; set; }
    }
}
