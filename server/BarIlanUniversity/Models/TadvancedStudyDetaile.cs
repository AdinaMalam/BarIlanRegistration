using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TadvancedStudyDetaile
    {
        public int IAdvancedStudyDetailesId { get; set; }
        public int? IAdvancedStudyId { get; set; }
        public string? NvAdvancedStudyTitle { get; set; }
        public string? NvAdvancedStudyDetailes { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
