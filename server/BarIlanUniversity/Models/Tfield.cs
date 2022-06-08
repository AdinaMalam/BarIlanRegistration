using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tfield
    {
        public Tfield()
        {
            ThistoryChanges = new HashSet<ThistoryChange>();
        }

        public int IFieldId { get; set; }
        public string? NvFieldNameEng { get; set; }
        public string? NvFieldNameHeb { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }

        public virtual ICollection<ThistoryChange> ThistoryChanges { get; set; }
    }
}
