using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tstudent
    {
        public int IStudentId { get; set; }
        public string? NvFirstName { get; set; }
        public string? NvLastName { get; set; }
        public string? NvMessagesPhone { get; set; }
        public string? NvEmail { get; set; }
        public string? NvIdentity { get; set; }
        public int? IInstitutionId { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
