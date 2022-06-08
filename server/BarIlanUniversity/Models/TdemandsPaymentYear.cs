using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TdemandsPaymentYear
    {
        public int IDemandsPaymentYearId { get; set; }
        public int IInstitutionId { get; set; }
        public int IYearId { get; set; }
        public int IDemandsPaymentType { get; set; }
        public string NvDemandsPaymentIdentity { get; set; } = null!;
        public decimal? IAmount { get; set; }
        public decimal? IPaidAmount { get; set; }
        public int? IPaymentMethodTypeId { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string? NvComment { get; set; }
        public int? IDemandsPaymentAdvancedStudyId { get; set; }
        public int? IAdvancedStudyStatusTypeId { get; set; }
    }
}
