using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tuser
    {
        public int IUserId { get; set; }
        public string? NvFirstName { get; set; }
        public string? NvLastName { get; set; }
        public string? NvMobile { get; set; }
        public string? NvMail { get; set; }
        public string? NvUserName { get; set; }
        public string? NvPassword { get; set; }
        public int IRoleType { get; set; }
        public int? IUserStatusType { get; set; }
        public int? IValidUserNameStatus { get; set; }
        public bool? BMaterialsCollector { get; set; }
        public DateTime? DtLatestEntering { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string? NvCarNumber { get; set; }
        public string? NvIdentityNumber { get; set; }
        public DateTime? DtStartWork { get; set; }
    }
}
