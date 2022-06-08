using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TreceiptPayment
    {
        public int IDocumentId { get; set; }
        public int? IInstitutionId { get; set; }
        public DateTime? DtDateOfMaturity { get; set; }
        public int? IPaymentMethodId { get; set; }
        public int? IChequeNum { get; set; }
        public int? IReferenceNum { get; set; }
        public int? IBankId { get; set; }
        public int? IBranchNum { get; set; }
        public int? IBankAccount { get; set; }
        public decimal? DAmount { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public int? IPaymentSubscriptionId { get; set; }
    }
}
