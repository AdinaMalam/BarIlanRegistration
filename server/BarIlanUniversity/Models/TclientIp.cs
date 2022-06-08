using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TclientIp
    {
        public int IClientIpId { get; set; }
        public int IPort { get; set; }
        public string NvAddress { get; set; } = null!;
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public int IIpStatus { get; set; }
    }
}
