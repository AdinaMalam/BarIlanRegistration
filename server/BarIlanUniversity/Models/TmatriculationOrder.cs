using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TmatriculationOrder
    {
        public int IMatriculationOrderId { get; set; }
        public int IMatriculationInstitutionId { get; set; }
        public int? IMatriculationParamTimeId { get; set; }
        public int? INumStudents { get; set; }
        public int? IOrderStatus { get; set; }
        public bool? BIsShipping { get; set; }
        public int? IGatherBy { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
