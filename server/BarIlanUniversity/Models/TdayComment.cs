using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TdayComment
    {
        public int ICommentId { get; set; }
        public string? NvComment { get; set; }
        public DateTime? DCommentDate { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
