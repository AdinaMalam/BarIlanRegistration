using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationParam
    {
        public int IMatriculationParamId { get; set; }
        public int IMatriculationId { get; set; }
        public string NvParamName { get; set; } = null!;
        public int IParamType { get; set; }
        public int ICreateByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
