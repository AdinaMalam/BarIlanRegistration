using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TinstitutionUser
    {
        public int IUserId { get; set; }
        public string NvUserName { get; set; } = null!;
        public string NvPassword { get; set; } = null!;
        public int IInstitutionId { get; set; }
        public int IInstitutionUserRoleId { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
