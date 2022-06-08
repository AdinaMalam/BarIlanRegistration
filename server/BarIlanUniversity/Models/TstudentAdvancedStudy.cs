using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TstudentAdvancedStudy
    {
        public int IStudentAdvancedStudyId { get; set; }
        public int IStudentId { get; set; }
        public int? IAdvancedStudyInstitutionId { get; set; }
        public bool? BAdvancedStudyDone { get; set; }
        public DateTime? DtRegistrationDate { get; set; }
        public int? IRegistrationStatus { get; set; }
        public DateTime? DtRegistrationStatusDate { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public bool? BGeneratedCertificate { get; set; }
        public string? NvComment { get; set; }
        public bool? BSigned { get; set; }
        public int? IDemandsPaymentYearId { get; set; }
    }
}
