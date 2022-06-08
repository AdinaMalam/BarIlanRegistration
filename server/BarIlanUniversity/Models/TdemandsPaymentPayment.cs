using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TdemandsPaymentPayment
    {
        public int IPaymentSubscriptionId { get; set; }
        public int IDemandsPaymentYearId { get; set; }
        public string? NvRefFileName { get; set; }
        public decimal? IAmount { get; set; }
        public string? NvBarnetFileName { get; set; }
        public int? IBarnetNumber { get; set; }
        public string? NvReceiptFileName { get; set; }
        public int? IReceiptNumber { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string? NvReceiptPaymentFileName { get; set; }
        public DateTime? DtRefFileNameCreateDate { get; set; }
    }
}
