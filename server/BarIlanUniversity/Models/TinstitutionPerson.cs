using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TinstitutionPerson
    {
        public int IUserId { get; set; }
        public string? NvFirstName { get; set; }
        public string? NvLastName { get; set; }
        public string? NvEmail { get; set; }
        public string? NvMobile { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
