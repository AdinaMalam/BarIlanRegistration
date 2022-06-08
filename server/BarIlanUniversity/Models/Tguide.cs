using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tguide
    {
        public int IGuideId { get; set; }
        public Guid NvGuide { get; set; }
        public int IUserId { get; set; }
        public int IGuideStatusId { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
