using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TinstitutionSubscriptionYear
    {
        public int IInstitutionSubscriptionYearId { get; set; }
        public int IInstitutionId { get; set; }
        public int IYearId { get; set; }
        public int ISubscriptionStatusId { get; set; }
        public int ISubscriptionType { get; set; }
        public string? NvMatriculationComment { get; set; }
        public int? ICreatedByUserId { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int? ISysRowStatus { get; set; }
    }
}
