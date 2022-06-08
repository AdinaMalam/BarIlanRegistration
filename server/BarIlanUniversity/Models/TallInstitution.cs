using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TallInstitution
    {
        public int IInstitutionId { get; set; }
        public string? NvSchoolName { get; set; }
        public string? NvOwnership { get; set; }
        public int? ICityType { get; set; }
        public string? NvAddress { get; set; }
        public int? IEducationLevel { get; set; }
        public string? NvPhone { get; set; }
        public string? NvFax { get; set; }
        public string? NvSecretariatMail { get; set; }
        public int? IDeliveryCityType { get; set; }
        public string? NvDeliveryAddress { get; set; }
        public int? IDeliveryZipCode { get; set; }
        public string? NvJhaddress { get; set; }
        public string? NvJhdeliveryAddress { get; set; }
        public int? INumStudents { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string? NvSchoolSymbol { get; set; }
    }
}
