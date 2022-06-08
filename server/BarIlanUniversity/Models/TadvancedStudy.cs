using System;
using System.Collections.Generic;

namespace BarIlanUniversity.Models
{
    public partial class TadvancedStudy
    {
        public int IAdvancedStudyId { get; set; }
        public string? NvName { get; set; }
        public DateTime? DFromDate { get; set; }
        public DateTime? DToDate { get; set; }
        public string? NvDate { get; set; }
        public TimeSpan? TFromHour { get; set; }
        public TimeSpan? TToHour { get; set; }
        public string? NvPosition { get; set; }
        public double? FToPay { get; set; }
        public int? IStudentsNumber { get; set; }
        public DateTime? DtFromDateRegistration { get; set; }
        public DateTime? DtToDateRegistration { get; set; }
        public bool? BCurrentAdvancedStudy { get; set; }
        public string? NvSubject { get; set; }
        public string? NvComment { get; set; }
        public string? NvMoreComment { get; set; }
        public string? NvInternalComment { get; set; }
        public string? NvMessage { get; set; }
        public bool? BDesignedForSubscribers { get; set; }
        public int? IAdvancedStudyTypeId { get; set; }
        public string? NvIntendedTo { get; set; }
        public bool? BPresented { get; set; }
        public double? FPriceForSubscriptions { get; set; }
        public double? FPriceForNotSubscriptions { get; set; }
        public int? INumStudentsForInstitution { get; set; }
        public string? NvDistrictCoordinator { get; set; }
        public string? NvMorningRefreshments { get; set; }
        public string? NvMorningProvider { get; set; }
        public string? NvMiddayRefreshments { get; set; }
        public string? NvMiddayProvider { get; set; }
        public bool? BIsActive { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public int? IPaymentMethod { get; set; }
        public string? NvDetailsPaymentMethod { get; set; }
    }
}
