using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationInstitutionTester
    {
        public int IMatriculationInstitutionTesterId { get; set; }
        public int IMatriculationInstitutionId { get; set; }
        public string NvTesterName { get; set; } = null!;
        public int ICreateByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
