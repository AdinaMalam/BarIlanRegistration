using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TlotteryDirector
    {
        public int ILotteryDirectorId { get; set; }
        public string NvFirstName { get; set; } = null!;
        public string NvLastName { get; set; } = null!;
        public string? NvEmail { get; set; }
        public string? NvEmail2 { get; set; }
        public int? ICityType { get; set; }
        public string? NvMobile { get; set; }
        public string? NvRegion { get; set; }
        public string? NvPhone { get; set; }
        public string? NvDeliveryAddress { get; set; }
        public int? IUserId { get; set; }
        public bool BIsActive { get; set; }
        public int ICreateByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
