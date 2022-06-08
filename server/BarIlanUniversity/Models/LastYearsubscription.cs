using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class LastYearsubscription
    {
        public string? NvSchoolSymbol { get; set; }
        public decimal? IAmount { get; set; }
        public int? IBarnetNumber { get; set; }
        public string? NvPaymentMethod { get; set; }
        public decimal? IPaydAmount { get; set; }
        public string? NvSubscription { get; set; }
        public string? F7 { get; set; }
    }
}
