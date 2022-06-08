using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationProduct
    {
        public int IMatriculationProductId { get; set; }
        public string NvProductName { get; set; } = null!;
        public string? NvDescereption { get; set; }
        public int INumStudent { get; set; }
        public int? INumReserve { get; set; }
        public int? IAmount { get; set; }
        public string? NvComment { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
