using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TinstitutionHistory
    {
        public int IInstitutionId { get; set; }
        public int IYearId { get; set; }
        public int? ISubscriptionType { get; set; }
        public decimal? IAmount { get; set; }
        public int? INumStudents { get; set; }
        public int? ICreatedByUserId { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int? ISysRowStatus { get; set; }
    }
}
