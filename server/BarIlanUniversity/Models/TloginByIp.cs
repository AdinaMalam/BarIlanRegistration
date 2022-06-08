using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TloginByIp
    {
        public int IClientIpId { get; set; }
        public DateTime DtLoginDate { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
