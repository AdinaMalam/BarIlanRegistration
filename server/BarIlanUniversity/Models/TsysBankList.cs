using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TsysBankList
    {
        public int IBankId { get; set; }
        public string? NvBankName { get; set; }
        public int? IBankNumber { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string? NvLink { get; set; }
    }
}
