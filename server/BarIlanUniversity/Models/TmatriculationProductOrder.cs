using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationProductOrder
    {
        public int IMatriculationProductOrderId { get; set; }
        public int IMatriculationProductId { get; set; }
        public int IMatriculationOrderId { get; set; }
        public int? IAmount { get; set; }
        public int? IGatherAmount { get; set; }
        public string? NvComment { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public bool? BIsGather { get; set; }
    }
}
