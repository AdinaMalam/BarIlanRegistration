﻿using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationInstitutionParam
    {
        public int IMatriculationInstitutionParamsId { get; set; }
        public int IMatriculationInstitutionId { get; set; }
        public int IMatriculationParamClassId { get; set; }
        public int IMatriculationParamTimeId { get; set; }
        public int? IValue { get; set; }
        public int ICreateByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
