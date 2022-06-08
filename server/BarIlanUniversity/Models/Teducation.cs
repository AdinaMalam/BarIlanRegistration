using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Teducation
    {
        public Teducation()
        {
            Tinstitutions = new HashSet<Tinstitution>();
        }

        public int IEducationId { get; set; }
        public string? NvName { get; set; }
        public string? NvAdress { get; set; }
        public string? NvNameContact { get; set; }
        public string? NvMailContact { get; set; }
        public string? NvPhoneContact { get; set; }
        public string? NvNumberAssociation { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }

        public virtual ICollection<Tinstitution> Tinstitutions { get; set; }
    }
}
