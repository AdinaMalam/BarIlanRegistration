using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TadvancedStudyInstitution
    {
        public int IAdvancedStudyInstitutionId { get; set; }
        public int IInstitutionId { get; set; }
        public int IAdvancedStudyId { get; set; }
        public bool BBioHekerTest { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
