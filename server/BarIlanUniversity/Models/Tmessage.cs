using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tmessage
    {
        public int IMessageId { get; set; }
        public string? NvRecipientNumber { get; set; }
        public string? NvSenderNumber { get; set; }
        public string? NvSubject { get; set; }
        public string? NvContent { get; set; }
        public int? ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
