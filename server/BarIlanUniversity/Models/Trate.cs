using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Trate
    {
        public int IRateId { get; set; }
        public int IYearId { get; set; }
        public int? IMinNumStudents { get; set; }
        public int? IMaxNumStudents { get; set; }
        public decimal? NRate { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
