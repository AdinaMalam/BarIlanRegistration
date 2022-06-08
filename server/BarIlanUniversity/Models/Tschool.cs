using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class Tschool
    {
        public int ISchoolId { get; set; }
        public string? NvSchoolName { get; set; }
        public int? ISchoolSymbol { get; set; }
        public int? ICityType { get; set; }
        public string? NvBiologyCoordinatorName { get; set; }
        public string? NvCoordinatorPhone { get; set; }
        public string? NvCoordinatorMail { get; set; }
        public string? NvResponsibleDistributionName { get; set; }
        public string? NvResponsibleDistributionPhone { get; set; }
        public string? NvProvincialAdvisorName { get; set; }
        public string? NvProvincialAdvisorPhone { get; set; }
        public int? INumTestedMorning5Units { get; set; }
        public int? INumTestedNoon5Units { get; set; }
        public int? INumTestedAfterNoon5Units { get; set; }
        public int? INumTested3Units { get; set; }
        public int? INumUnits { get; set; }
        public bool? BSelfPickup { get; set; }
        public int? ISchoolType { get; set; }
        public string? NvComments { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
    }
}
