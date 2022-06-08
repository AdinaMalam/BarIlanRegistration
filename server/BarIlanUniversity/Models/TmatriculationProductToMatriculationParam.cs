using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationProductToMatriculationParam
    {
        public int IMatriculationProductToMatriculationParamId { get; set; }
        public int IMatriculationProductId { get; set; }
        public int IMatriculationId { get; set; }
        public int IMatriculationParamId { get; set; }
        public int? IMaxStudent { get; set; }
        public int? ICount { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
