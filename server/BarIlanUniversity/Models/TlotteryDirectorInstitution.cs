using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TlotteryDirectorInstitution
    {
        public int ILotteryDirectorInstitutionId { get; set; }
        public int IInstitutionId { get; set; }
        public int ILotteryDirectorId { get; set; }
        public int ICreateByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
