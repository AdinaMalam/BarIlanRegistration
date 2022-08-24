using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BarIlanUniversity.Models
{
    public partial class BarIlanBiologyRegistrationContext : DbContext
    {
        public BarIlanBiologyRegistrationContext()
        {
        }

        public BarIlanBiologyRegistrationContext(DbContextOptions<BarIlanBiologyRegistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ImpLotteryDirector> ImpLotteryDirectors { get; set; } = null!;
        public virtual DbSet<ImpModerator> ImpModerators { get; set; } = null!;
        public virtual DbSet<ImpModeratorInstitution> ImpModeratorInstitutions { get; set; } = null!;
        public virtual DbSet<ImpModerators2019> ImpModerators2019s { get; set; } = null!;
        public virtual DbSet<LastYearsubscription> LastYearsubscriptions { get; set; } = null!;
        public virtual DbSet<MatriculationImport2022> MatriculationImport2022s { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;
        public virtual DbSet<TadvancedStudy> TadvancedStudies { get; set; } = null!;
        public virtual DbSet<TadvancedStudyDetaile> TadvancedStudyDetailes { get; set; } = null!;
        public virtual DbSet<TadvancedStudyInstitution> TadvancedStudyInstitutions { get; set; } = null!;
        public virtual DbSet<TallInstitution> TallInstitutions { get; set; } = null!;
        public virtual DbSet<TclientIp> TclientIps { get; set; } = null!;
        public virtual DbSet<TcontentTag> TcontentTags { get; set; } = null!;
        public virtual DbSet<TdayComment> TdayComments { get; set; } = null!;
        public virtual DbSet<TdemandsPaymentPayment> TdemandsPaymentPayments { get; set; } = null!;
        public virtual DbSet<TdemandsPaymentYear> TdemandsPaymentYears { get; set; } = null!;
        public virtual DbSet<Teducation> Teducations { get; set; } = null!;
        public virtual DbSet<TempImport> TempImports { get; set; } = null!;
        public virtual DbSet<Tfield> Tfields { get; set; } = null!;
        public virtual DbSet<Tfile> Tfiles { get; set; } = null!;
        public virtual DbSet<Tguide> Tguides { get; set; } = null!;
        public virtual DbSet<ThistoryChange> ThistoryChanges { get; set; } = null!;
        public virtual DbSet<Tinstitution> Tinstitutions { get; set; } = null!;
        public virtual DbSet<TinstitutionHistory> TinstitutionHistories { get; set; } = null!;
        public virtual DbSet<TinstitutionPerson> TinstitutionPeople { get; set; } = null!;
        public virtual DbSet<TinstitutionSubscriptionYear> TinstitutionSubscriptionYears { get; set; } = null!;
        public virtual DbSet<TinstitutionUser> TinstitutionUsers { get; set; } = null!;
        public virtual DbSet<TloginByIp> TloginByIps { get; set; } = null!;
        public virtual DbSet<TloginByUserName> TloginByUserNames { get; set; } = null!;
        public virtual DbSet<TlotteryDirector> TlotteryDirectors { get; set; } = null!;
        public virtual DbSet<TlotteryDirectorInstitution> TlotteryDirectorInstitutions { get; set; } = null!;
        public virtual DbSet<Tmatriculation> Tmatriculations { get; set; } = null!;
        public virtual DbSet<TmatriculationInstitution> TmatriculationInstitutions { get; set; } = null!;
        public virtual DbSet<TmatriculationInstitutionParam> TmatriculationInstitutionParams { get; set; } = null!;
        public virtual DbSet<TmatriculationInstitutionTester> TmatriculationInstitutionTesters { get; set; } = null!;
        public virtual DbSet<TmatriculationOrder> TmatriculationOrders { get; set; } = null!;
        public virtual DbSet<TmatriculationParam> TmatriculationParams { get; set; } = null!;
        public virtual DbSet<TmatriculationProduct> TmatriculationProducts { get; set; } = null!;
        public virtual DbSet<TmatriculationProductOrder> TmatriculationProductOrders { get; set; } = null!;
        public virtual DbSet<TmatriculationProductToMatriculationParam> TmatriculationProductToMatriculationParams { get; set; } = null!;
        public virtual DbSet<Tmessage> Tmessages { get; set; } = null!;
        public virtual DbSet<Tmoderator> Tmoderators { get; set; } = null!;
        public virtual DbSet<TmoderatorInstitution> TmoderatorInstitutions { get; set; } = null!;
        public virtual DbSet<Trate> Trates { get; set; } = null!;
        public virtual DbSet<TreceiptPayment> TreceiptPayments { get; set; } = null!;
        public virtual DbSet<Tschool> Tschools { get; set; } = null!;
        public virtual DbSet<Tsetting> Tsettings { get; set; } = null!;
        public virtual DbSet<Tstudent> Tstudents { get; set; } = null!;
        public virtual DbSet<TstudentAdvancedStudy> TstudentAdvancedStudies { get; set; } = null!;
        public virtual DbSet<TsysBankList> TsysBankLists { get; set; } = null!;
        public virtual DbSet<TsysLog> TsysLogs { get; set; } = null!;
        public virtual DbSet<TsysLogMail> TsysLogMails { get; set; } = null!;
        public virtual DbSet<TsysTable> TsysTables { get; set; } = null!;
        public virtual DbSet<TsysTableRow> TsysTableRows { get; set; } = null!;
        public virtual DbSet<Tuser> Tusers { get; set; } = null!;
        public virtual DbSet<Tyear> Tyears { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.1.1.2;Database=BarIlanBiologyRegistration;User Id=sa;Password=q1w2e3r4A123;TrustServerCertificate=True;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImpLotteryDirector>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imp_LotteryDirector");

                entity.Property(e => e.ICityType)
                    .HasMaxLength(255)
                    .HasColumnName("iCityType");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(255)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvEmail2)
                    .HasMaxLength(255)
                    .HasColumnName("nvEmail2");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(255)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(255)
                    .HasColumnName("nvMobile");

                entity.Property(e => e.סמלמוסד)
                    .HasMaxLength(255)
                    .HasColumnName("סמל מוסד");

                entity.Property(e => e.סמלמוסדקודם)
                    .HasMaxLength(255)
                    .HasColumnName("סמל מוסד קודם");
            });

            modelBuilder.Entity<ImpModerator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imp_Moderators");

                entity.Property(e => e.NvAddress)
                    .HasMaxLength(255)
                    .HasColumnName("nvAddress");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(255)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvName)
                    .HasMaxLength(255)
                    .HasColumnName("nvName");

                entity.Property(e => e.NvPhone)
                    .HasMaxLength(255)
                    .HasColumnName("nvPhone");

                entity.Property(e => e.NvRegion)
                    .HasMaxLength(255)
                    .HasColumnName("nvRegion");
            });

            modelBuilder.Entity<ImpModeratorInstitution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imp_ModeratorInstitution");

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.NvName)
                    .HasMaxLength(255)
                    .HasColumnName("nvName");

                entity.Property(e => e.NvScholSymbol)
                    .HasMaxLength(255)
                    .HasColumnName("nvScholSymbol");
            });

            modelBuilder.Entity<ImpModerators2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IMP_MODERATORS_2019");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F6).HasMaxLength(255);

                entity.Property(e => e.F7).HasMaxLength(255);

                entity.Property(e => e.NvModerator)
                    .HasMaxLength(255)
                    .HasColumnName("nvModerator");

                entity.Property(e => e.NvSchoolName)
                    .HasMaxLength(255)
                    .HasColumnName("nvSchoolName");

                entity.Property(e => e.NvSchoolSymbol)
                    .HasMaxLength(255)
                    .HasColumnName("nvSchoolSymbol");
            });

            modelBuilder.Entity<LastYearsubscription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LastYearsubscription");

                entity.Property(e => e.F7).HasMaxLength(255);

                entity.Property(e => e.IAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("iAmount");

                entity.Property(e => e.IBarnetNumber).HasColumnName("iBarnetNumber");

                entity.Property(e => e.IPaydAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("iPaydAmount");

                entity.Property(e => e.NvPaymentMethod)
                    .HasMaxLength(255)
                    .HasColumnName("nvPaymentMethod");

                entity.Property(e => e.NvSchoolSymbol)
                    .HasMaxLength(255)
                    .HasColumnName("nvSchoolSymbol");

                entity.Property(e => e.NvSubscription)
                    .HasMaxLength(255)
                    .HasColumnName("nvSubscription");
            });

            modelBuilder.Entity<MatriculationImport2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Matriculation_Import_2022");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.SemelMosad)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.ICount).HasColumnName("iCount");

                entity.Property(e => e.IMaxStudents).HasColumnName("iMaxStudents");

                entity.Property(e => e.IParam).HasColumnName("iParam");

                entity.Property(e => e.IProductId).HasColumnName("iProductId");
            });

            modelBuilder.Entity<TadvancedStudy>(entity =>
            {
                entity.HasKey(e => e.IAdvancedStudyId)
                    .HasName("PK_TAdvancedStudyId");

                entity.ToTable("TAdvancedStudy");

                entity.Property(e => e.IAdvancedStudyId).HasColumnName("iAdvancedStudyId");

                entity.Property(e => e.BCurrentAdvancedStudy).HasColumnName("bCurrentAdvancedStudy");

                entity.Property(e => e.BDesignedForSubscribers).HasColumnName("bDesignedForSubscribers");

                entity.Property(e => e.BIsActive).HasColumnName("bIsActive");

                entity.Property(e => e.BPresented).HasColumnName("bPresented");

                entity.Property(e => e.DFromDate)
                    .HasColumnType("date")
                    .HasColumnName("dFromDate");

                entity.Property(e => e.DToDate)
                    .HasColumnType("date")
                    .HasColumnName("dToDate");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtFromDateRegistration)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFromDateRegistration");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.DtToDateRegistration)
                    .HasColumnType("datetime")
                    .HasColumnName("dtToDateRegistration");

                entity.Property(e => e.FPriceForNotSubscriptions).HasColumnName("fPriceForNotSubscriptions");

                entity.Property(e => e.FPriceForSubscriptions).HasColumnName("fPriceForSubscriptions");

                entity.Property(e => e.FToPay).HasColumnName("fToPay");

                entity.Property(e => e.IAdvancedStudyTypeId).HasColumnName("iAdvancedStudyTypeId");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumStudentsForInstitution).HasColumnName("iNumStudentsForInstitution");

                entity.Property(e => e.IPaymentMethod).HasColumnName("iPaymentMethod");

                entity.Property(e => e.IStudentsNumber).HasColumnName("iStudentsNumber");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvComment).HasColumnName("nvComment");

                entity.Property(e => e.NvDate).HasColumnName("nvDate");

                entity.Property(e => e.NvDetailsPaymentMethod).HasColumnName("nvDetailsPaymentMethod");

                entity.Property(e => e.NvDistrictCoordinator).HasColumnName("nvDistrictCoordinator");

                entity.Property(e => e.NvIntendedTo).HasColumnName("nvIntendedTo");

                entity.Property(e => e.NvInternalComment).HasColumnName("nvInternalComment");

                entity.Property(e => e.NvMessage).HasColumnName("nvMessage");

                entity.Property(e => e.NvMiddayProvider).HasColumnName("nvMiddayProvider");

                entity.Property(e => e.NvMiddayRefreshments).HasColumnName("nvMiddayRefreshments");

                entity.Property(e => e.NvMoreComment).HasColumnName("nvMoreComment");

                entity.Property(e => e.NvMorningProvider).HasColumnName("nvMorningProvider");

                entity.Property(e => e.NvMorningRefreshments).HasColumnName("nvMorningRefreshments");

                entity.Property(e => e.NvName)
                    .HasMaxLength(200)
                    .HasColumnName("nvName");

                entity.Property(e => e.NvPosition).HasColumnName("nvPosition");

                entity.Property(e => e.NvSubject).HasColumnName("nvSubject");

                entity.Property(e => e.TFromHour).HasColumnName("tFromHour");

                entity.Property(e => e.TToHour).HasColumnName("tToHour");
            });

            modelBuilder.Entity<TadvancedStudyDetaile>(entity =>
            {
                entity.HasKey(e => e.IAdvancedStudyDetailesId);

                entity.ToTable("TAdvancedStudyDetailes");

                entity.Property(e => e.IAdvancedStudyDetailesId).HasColumnName("iAdvancedStudyDetailesId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAdvancedStudyId).HasColumnName("iAdvancedStudyId");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvAdvancedStudyDetailes).HasColumnName("nvAdvancedStudyDetailes");

                entity.Property(e => e.NvAdvancedStudyTitle)
                    .HasMaxLength(200)
                    .HasColumnName("nvAdvancedStudyTitle");
            });

            modelBuilder.Entity<TadvancedStudyInstitution>(entity =>
            {
                entity.HasKey(e => e.IAdvancedStudyInstitutionId);

                entity.ToTable("TAdvancedStudyInstitution");

                entity.Property(e => e.IAdvancedStudyInstitutionId).HasColumnName("iAdvancedStudyInstitutionId");

                entity.Property(e => e.BBioHekerTest).HasColumnName("bBioHekerTest");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.IAdvancedStudyId).HasColumnName("iAdvancedStudyId");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<TallInstitution>(entity =>
            {
                entity.HasKey(e => e.IInstitutionId);

                entity.ToTable("TAllInstitutions");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICityType).HasColumnName("iCityType");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IDeliveryCityType).HasColumnName("iDeliveryCityType");

                entity.Property(e => e.IDeliveryZipCode).HasColumnName("iDeliveryZipCode");

                entity.Property(e => e.IEducationLevel).HasColumnName("iEducationLevel");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumStudents).HasColumnName("iNumStudents");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvAddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvAddress");

                entity.Property(e => e.NvDeliveryAddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvDeliveryAddress");

                entity.Property(e => e.NvFax)
                    .HasMaxLength(50)
                    .HasColumnName("nvFax");

                entity.Property(e => e.NvJhaddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvJHAddress");

                entity.Property(e => e.NvJhdeliveryAddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvJHDeliveryAddress");

                entity.Property(e => e.NvOwnership)
                    .HasMaxLength(50)
                    .HasColumnName("nvOwnership");

                entity.Property(e => e.NvPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvPhone");

                entity.Property(e => e.NvSchoolName)
                    .HasMaxLength(50)
                    .HasColumnName("nvSchoolName");

                entity.Property(e => e.NvSchoolSymbol)
                    .HasMaxLength(50)
                    .HasColumnName("nvSchoolSymbol");

                entity.Property(e => e.NvSecretariatMail)
                    .HasMaxLength(50)
                    .HasColumnName("nvSecretariatMail");
            });

            modelBuilder.Entity<TclientIp>(entity =>
            {
                entity.HasKey(e => e.IClientIpId);

                entity.ToTable("TClientIp");

                entity.Property(e => e.IClientIpId).HasColumnName("iClientIpId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IIpStatus).HasColumnName("iIpStatus");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IPort).HasColumnName("iPort");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvAddress)
                    .HasMaxLength(250)
                    .HasColumnName("nvAddress");
            });

            modelBuilder.Entity<TcontentTag>(entity =>
            {
                entity.HasKey(e => e.IContentTagId);

                entity.ToTable("TContentTag");

                entity.Property(e => e.IContentTagId).HasColumnName("iContentTagId");

                entity.Property(e => e.NvContentTagName)
                    .HasMaxLength(50)
                    .HasColumnName("nvContentTagName");

                entity.Property(e => e.NvDisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("nvDisplayName");

                entity.Property(e => e.NvFieldDisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFieldDisplayName");
            });

            modelBuilder.Entity<TdayComment>(entity =>
            {
                entity.HasKey(e => e.ICommentId)
                    .HasName("PK_TComment");

                entity.ToTable("TDayComment");

                entity.Property(e => e.ICommentId).HasColumnName("iCommentId");

                entity.Property(e => e.DCommentDate)
                    .HasColumnType("date")
                    .HasColumnName("dCommentDate");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvComment).HasColumnName("nvComment");
            });

            modelBuilder.Entity<TdemandsPaymentPayment>(entity =>
            {
                entity.HasKey(e => e.IPaymentSubscriptionId)
                    .HasName("PK_TPaymentSubscription");

                entity.ToTable("TDemandsPaymentPayments");

                entity.Property(e => e.IPaymentSubscriptionId).HasColumnName("iPaymentSubscriptionId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.DtRefFileNameCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtRefFileNameCreateDate");

                entity.Property(e => e.IAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("iAmount");

                entity.Property(e => e.IBarnetNumber).HasColumnName("iBarnetNumber");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IDemandsPaymentYearId).HasColumnName("iDemandsPaymentYearId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IReceiptNumber).HasColumnName("iReceiptNumber");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvBarnetFileName)
                    .HasMaxLength(100)
                    .HasColumnName("nvBarnetFileName");

                entity.Property(e => e.NvReceiptFileName)
                    .HasMaxLength(100)
                    .HasColumnName("nvReceiptFileName");

                entity.Property(e => e.NvReceiptPaymentFileName)
                    .HasMaxLength(100)
                    .HasColumnName("nvReceiptPaymentFileName");

                entity.Property(e => e.NvRefFileName)
                    .HasMaxLength(100)
                    .HasColumnName("nvRefFileName");
            });

            modelBuilder.Entity<TdemandsPaymentYear>(entity =>
            {
                entity.HasKey(e => e.IDemandsPaymentYearId)
                    .HasName("PK_TDemandsPaymentYear_1");

                entity.ToTable("TDemandsPaymentYear");

                entity.Property(e => e.IDemandsPaymentYearId).HasColumnName("iDemandsPaymentYearId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.IAdvancedStudyStatusTypeId).HasColumnName("iAdvancedStudyStatusTypeId");

                entity.Property(e => e.IAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("iAmount");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IDemandsPaymentAdvancedStudyId).HasColumnName("iDemandsPaymentAdvancedStudyId");

                entity.Property(e => e.IDemandsPaymentType).HasColumnName("iDemandsPaymentType");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IPaidAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("iPaidAmount");

                entity.Property(e => e.IPaymentMethodTypeId).HasColumnName("iPaymentMethodTypeId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.IYearId).HasColumnName("iYearId");

                entity.Property(e => e.NvComment).HasColumnName("nvComment");

                entity.Property(e => e.NvDemandsPaymentIdentity)
                    .HasMaxLength(50)
                    .HasColumnName("nvDemandsPaymentIdentity");
            });

            modelBuilder.Entity<Teducation>(entity =>
            {
                entity.HasKey(e => e.IEducationId);

                entity.ToTable("TEducation");

                entity.Property(e => e.IEducationId).HasColumnName("iEducationId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvAdress)
                    .HasMaxLength(50)
                    .HasColumnName("nvAdress");

                entity.Property(e => e.NvMailContact)
                    .HasMaxLength(50)
                    .HasColumnName("nvMailContact");

                entity.Property(e => e.NvName)
                    .HasMaxLength(50)
                    .HasColumnName("nvName");

                entity.Property(e => e.NvNameContact)
                    .HasMaxLength(50)
                    .HasColumnName("nvNameContact");

                entity.Property(e => e.NvNumberAssociation)
                    .HasMaxLength(50)
                    .HasColumnName("nvNumberAssociation");

                entity.Property(e => e.NvPhoneContact)
                    .HasMaxLength(50)
                    .HasColumnName("nvPhoneContact");
            });

            modelBuilder.Entity<TempImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_IMPORT");

                entity.Property(e => e.IIndex).HasColumnName("iIndex");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(250)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvInstitutionSymbol)
                    .HasMaxLength(50)
                    .HasColumnName("nvInstitutionSymbol");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(250)
                    .HasColumnName("nvLastName");
            });

            modelBuilder.Entity<Tfield>(entity =>
            {
                entity.HasKey(e => e.IFieldId)
                    .HasName("PK_T_Field");

                entity.ToTable("TField");

                entity.Property(e => e.IFieldId).HasColumnName("iFieldId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvFieldNameEng)
                    .HasMaxLength(100)
                    .HasColumnName("nvFieldNameEng");

                entity.Property(e => e.NvFieldNameHeb)
                    .HasMaxLength(100)
                    .HasColumnName("nvFieldNameHeb");
            });

            modelBuilder.Entity<Tfile>(entity =>
            {
                entity.HasKey(e => e.IFileId);

                entity.ToTable("TFile");

                entity.Property(e => e.IFileId).HasColumnName("iFileId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvDescription)
                    .HasMaxLength(250)
                    .HasColumnName("nvDescription");

                entity.Property(e => e.NvFile)
                    .HasMaxLength(900)
                    .HasColumnName("nvFile");

                entity.Property(e => e.NvFileName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFileName");

                entity.Property(e => e.NvLink)
                    .HasMaxLength(900)
                    .HasColumnName("nvLink");
            });

            modelBuilder.Entity<Tguide>(entity =>
            {
                entity.HasKey(e => e.IGuideId);

                entity.ToTable("TGuide");

                entity.Property(e => e.IGuideId).HasColumnName("iGuideId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IGuideStatusId).HasColumnName("iGuideStatusId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.NvGuide).HasColumnName("nvGuide");
            });

            modelBuilder.Entity<ThistoryChange>(entity =>
            {
                entity.HasKey(e => e.IHistoryChangesId)
                    .HasName("PK_T_HistoryChanges");

                entity.ToTable("THistoryChanges");

                entity.Property(e => e.IHistoryChangesId).HasColumnName("iHistoryChangesId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IFieldId).HasColumnName("iFieldId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvNewValue)
                    .HasMaxLength(100)
                    .HasColumnName("nvNewValue");

                entity.Property(e => e.NvOldValue)
                    .HasMaxLength(100)
                    .HasColumnName("nvOldValue");

                entity.HasOne(d => d.IField)
                    .WithMany(p => p.ThistoryChanges)
                    .HasForeignKey(d => d.IFieldId)
                    .HasConstraintName("FK_THistoryChanges_TField");
            });

            modelBuilder.Entity<Tinstitution>(entity =>
            {
                entity.HasKey(e => e.IInstitutionId);

                entity.ToTable("TInstitution");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.BIsDeliveryByCourier).HasColumnName("bIsDeliveryByCourier");

                entity.Property(e => e.BSelfPickup).HasColumnName("bSelfPickup");

                entity.Property(e => e.BWinOlympiad).HasColumnName("bWinOlympiad");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICityType).HasColumnName("iCityType");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IDaysWaitingPeriodForPayment).HasColumnName("iDaysWaitingPeriodForPayment");

                entity.Property(e => e.IDeliveryCityType).HasColumnName("iDeliveryCityType");

                entity.Property(e => e.IDeliveryZipCode).HasColumnName("iDeliveryZipCode");

                entity.Property(e => e.IEducationId).HasColumnName("iEducationId");

                entity.Property(e => e.IEducationLevel).HasColumnName("iEducationLevel");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumStudents).HasColumnName("iNumStudents");

                entity.Property(e => e.INumTested3Units).HasColumnName("iNumTested3Units");

                entity.Property(e => e.INumTestedAfterNoon5Units).HasColumnName("iNumTestedAfterNoon5Units");

                entity.Property(e => e.INumTestedMorning5Units).HasColumnName("iNumTestedMorning5Units");

                entity.Property(e => e.INumTestedNoon5Units).HasColumnName("iNumTestedNoon5Units");

                entity.Property(e => e.INumUnits).HasColumnName("iNumUnits");

                entity.Property(e => e.ISchoolType).HasColumnName("iSchoolType");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IZipCode).HasColumnName("iZipCode");

                entity.Property(e => e.NvAddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvAddress");

                entity.Property(e => e.NvBiologyCoordinatorName)
                    .HasMaxLength(50)
                    .HasColumnName("nvBiologyCoordinatorName");

                entity.Property(e => e.NvComments)
                    .HasMaxLength(500)
                    .HasColumnName("nvComments");

                entity.Property(e => e.NvCoordinatorMail)
                    .HasMaxLength(50)
                    .HasColumnName("nvCoordinatorMail");

                entity.Property(e => e.NvCoordinatorPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvCoordinatorPhone");

                entity.Property(e => e.NvDeliveryAddress)
                    .HasMaxLength(50)
                    .HasColumnName("nvDeliveryAddress");

                entity.Property(e => e.NvFax)
                    .HasMaxLength(50)
                    .HasColumnName("nvFax");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(50)
                    .HasColumnName("nvMobile");

                entity.Property(e => e.NvOwnership)
                    .HasMaxLength(50)
                    .HasColumnName("nvOwnership");

                entity.Property(e => e.NvPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvPhone");

                entity.Property(e => e.NvProvincialAdvisorName)
                    .HasMaxLength(50)
                    .HasColumnName("nvProvincialAdvisorName");

                entity.Property(e => e.NvProvincialAdvisorPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvProvincialAdvisorPhone");

                entity.Property(e => e.NvResponsibleDistributionName)
                    .HasMaxLength(50)
                    .HasColumnName("nvResponsibleDistributionName");

                entity.Property(e => e.NvResponsibleDistributionPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvResponsibleDistributionPhone");

                entity.Property(e => e.NvSchoolName)
                    .HasMaxLength(50)
                    .HasColumnName("nvSchoolName");

                entity.Property(e => e.NvSchoolSymbol)
                    .HasMaxLength(50)
                    .HasColumnName("nvSchoolSymbol");

                entity.Property(e => e.NvSecretariatMail)
                    .HasMaxLength(50)
                    .HasColumnName("nvSecretariatMail");

                entity.HasOne(d => d.IEducation)
                    .WithMany(p => p.Tinstitutions)
                    .HasForeignKey(d => d.IEducationId)
                    .HasConstraintName("FK_TInstitution_TEducation");
            });

            modelBuilder.Entity<TinstitutionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TInstitutionHistory");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("iAmount");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumStudents).HasColumnName("iNumStudents");

                entity.Property(e => e.ISubscriptionType).HasColumnName("iSubscriptionType");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IYearId).HasColumnName("iYearId");
            });

            modelBuilder.Entity<TinstitutionPerson>(entity =>
            {
                entity.HasKey(e => e.IUserId);

                entity.ToTable("TInstitutionPerson");

                entity.Property(e => e.IUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("iUserId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(200)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(200)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(200)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(20)
                    .HasColumnName("nvMobile");
            });

            modelBuilder.Entity<TinstitutionSubscriptionYear>(entity =>
            {
                entity.HasKey(e => e.IInstitutionSubscriptionYearId);

                entity.ToTable("TInstitutionSubscriptionYear");

                entity.Property(e => e.IInstitutionSubscriptionYearId).HasColumnName("iInstitutionSubscriptionYearId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISubscriptionStatusId).HasColumnName("iSubscriptionStatusId");

                entity.Property(e => e.ISubscriptionType).HasColumnName("iSubscriptionType");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IYearId).HasColumnName("iYearId");

                entity.Property(e => e.NvMatriculationComment).HasColumnName("nvMatriculationComment");
            });

            modelBuilder.Entity<TinstitutionUser>(entity =>
            {
                entity.HasKey(e => e.IUserId);

                entity.ToTable("TInstitutionUser");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.IInstitutionUserRoleId).HasColumnName("iInstitutionUserRoleId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvPassword)
                    .HasMaxLength(50)
                    .HasColumnName("nvPassword");

                entity.Property(e => e.NvUserName)
                    .HasMaxLength(50)
                    .HasColumnName("nvUserName");
            });

            modelBuilder.Entity<TloginByIp>(entity =>
            {
                entity.HasKey(e => new { e.IClientIpId, e.DtLoginDate });

                entity.ToTable("TLoginByIp");

                entity.Property(e => e.IClientIpId).HasColumnName("iClientIpId");

                entity.Property(e => e.DtLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLoginDate");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<TloginByUserName>(entity =>
            {
                entity.HasKey(e => new { e.IUserId, e.DtLoginDate });

                entity.ToTable("TLoginByUserName");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.DtLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLoginDate");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<TlotteryDirector>(entity =>
            {
                entity.HasKey(e => e.ILotteryDirectorId);

                entity.ToTable("TLotteryDirector");

                entity.Property(e => e.ILotteryDirectorId).HasColumnName("iLotteryDirectorId");

                entity.Property(e => e.BIsActive).HasColumnName("bIsActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICityType).HasColumnName("iCityType");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.NvDeliveryAddress)
                    .HasMaxLength(100)
                    .HasColumnName("nvDeliveryAddress");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(50)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvEmail2)
                    .HasMaxLength(50)
                    .HasColumnName("nvEmail2");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(50)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(50)
                    .HasColumnName("nvMobile");

                entity.Property(e => e.NvPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvPhone");

                entity.Property(e => e.NvRegion)
                    .HasMaxLength(50)
                    .HasColumnName("nvRegion");
            });

            modelBuilder.Entity<TlotteryDirectorInstitution>(entity =>
            {
                entity.HasKey(e => e.ILotteryDirectorInstitutionId);

                entity.ToTable("TLotteryDirectorInstitution");

                entity.Property(e => e.ILotteryDirectorInstitutionId).HasColumnName("iLotteryDirectorInstitutionId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ILotteryDirectorId).HasColumnName("iLotteryDirectorId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<Tmatriculation>(entity =>
            {
                entity.HasKey(e => e.IMatriculationId);

                entity.ToTable("TMatriculation");

                entity.Property(e => e.IMatriculationId).HasColumnName("iMatriculationId");

                entity.Property(e => e.BCreatedOrders).HasColumnName("bCreatedOrders");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtMatriculationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMatriculationDate");

                entity.Property(e => e.DtStudentsLastUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtStudentsLastUpdateDate");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IUnits).HasColumnName("iUnits");

                entity.Property(e => e.IYearId).HasColumnName("iYearId");

                entity.Property(e => e.NvMatriculationName)
                    .HasMaxLength(50)
                    .HasColumnName("nvMatriculationName");
            });

            modelBuilder.Entity<TmatriculationInstitution>(entity =>
            {
                entity.HasKey(e => e.IMatriculationInstitutionId);

                entity.ToTable("TMatriculationInstitution");

                entity.HasIndex(e => e.IInstitutionId, "IX_TMatriculationInstitution");

                entity.Property(e => e.IMatriculationInstitutionId).HasColumnName("iMatriculationInstitutionId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.IDeliveryModeratorId).HasColumnName("iDeliveryModeratorId");

                entity.Property(e => e.IDeliveryType).HasColumnName("iDeliveryType");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILaboratoryRooms).HasColumnName("iLaboratoryRooms");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationId).HasColumnName("iMatriculationId");

                entity.Property(e => e.IRegistrationType).HasColumnName("iRegistrationType");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TmatriculationInstitutionParam>(entity =>
            {
                entity.HasKey(e => e.IMatriculationInstitutionParamsId)
                    .HasName("PK_TTMatriculationInstitutionParams");

                entity.ToTable("TMatriculationInstitutionParams");

                entity.Property(e => e.IMatriculationInstitutionParamsId).HasColumnName("iMatriculationInstitutionParamsId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationInstitutionId).HasColumnName("iMatriculationInstitutionId");

                entity.Property(e => e.IMatriculationParamClassId).HasColumnName("iMatriculationParamClassId");

                entity.Property(e => e.IMatriculationParamTimeId).HasColumnName("iMatriculationParamTimeId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IValue).HasColumnName("iValue");
            });

            modelBuilder.Entity<TmatriculationInstitutionTester>(entity =>
            {
                entity.HasKey(e => e.IMatriculationInstitutionTesterId);

                entity.ToTable("TMatriculationInstitutionTester");

                entity.Property(e => e.IMatriculationInstitutionTesterId).HasColumnName("iMatriculationInstitutionTesterId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationInstitutionId).HasColumnName("iMatriculationInstitutionId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvTesterName)
                    .HasMaxLength(150)
                    .HasColumnName("nvTesterName");
            });

            modelBuilder.Entity<TmatriculationOrder>(entity =>
            {
                entity.HasKey(e => e.IMatriculationOrderId);

                entity.ToTable("TMatriculationOrder");

                entity.Property(e => e.IMatriculationOrderId).HasColumnName("iMatriculationOrderId");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IGatherBy).HasColumnName("iGatherBy");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationInstitutionId).HasColumnName("iMatriculationInstitutionId");

                entity.Property(e => e.IMatriculationParamTimeId).HasColumnName("iMatriculationParamTimeId");

                entity.Property(e => e.INumStudents).HasColumnName("iNumStudents");

                entity.Property(e => e.IOrderStatus).HasColumnName("iOrderStatus");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<TmatriculationParam>(entity =>
            {
                entity.HasKey(e => e.IMatriculationParamId);

                entity.ToTable("TMatriculationParams");

                entity.Property(e => e.IMatriculationParamId).HasColumnName("iMatriculationParamId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationId).HasColumnName("iMatriculationId");

                entity.Property(e => e.IParamType).HasColumnName("iParamType");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvParamName)
                    .HasMaxLength(50)
                    .HasColumnName("nvParamName");
            });

            modelBuilder.Entity<TmatriculationProduct>(entity =>
            {
                entity.HasKey(e => e.IMatriculationProductId)
                    .HasName("PK_TNewTMatriculationProduct");

                entity.ToTable("TMatriculationProduct");

                entity.Property(e => e.IMatriculationProductId).HasColumnName("iMatriculationProductId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAmount).HasColumnName("iAmount");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumReserve).HasColumnName("iNumReserve");

                entity.Property(e => e.INumStudent).HasColumnName("iNumStudent");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvComment)
                    .IsUnicode(false)
                    .HasColumnName("nvComment");

                entity.Property(e => e.NvDescereption).HasColumnName("nvDescereption");

                entity.Property(e => e.NvProductName)
                    .HasMaxLength(500)
                    .HasColumnName("nvProductName");
            });

            modelBuilder.Entity<TmatriculationProductOrder>(entity =>
            {
                entity.HasKey(e => e.IMatriculationProductOrderId)
                    .HasName("PK_TMatriculationOrderProduct");

                entity.ToTable("TMatriculationProductOrder");

                entity.Property(e => e.IMatriculationProductOrderId).HasColumnName("iMatriculationProductOrderId");

                entity.Property(e => e.BIsGather).HasColumnName("bIsGather");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.IAmount).HasColumnName("iAmount");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IGatherAmount).HasColumnName("iGatherAmount");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationOrderId).HasColumnName("iMatriculationOrderId");

                entity.Property(e => e.IMatriculationProductId).HasColumnName("iMatriculationProductId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvComment).HasColumnName("nvComment");
            });

            modelBuilder.Entity<TmatriculationProductToMatriculationParam>(entity =>
            {
                entity.HasKey(e => e.IMatriculationProductToMatriculationParamId)
                    .HasName("PK_[TMatriculationProductToMatriculationParam");

                entity.ToTable("TMatriculationProductToMatriculationParam");

                entity.Property(e => e.IMatriculationProductToMatriculationParamId).HasColumnName("iMatriculationProductToMatriculationParamId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICount).HasColumnName("iCount");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMatriculationId).HasColumnName("iMatriculationId");

                entity.Property(e => e.IMatriculationParamId).HasColumnName("iMatriculationParamId");

                entity.Property(e => e.IMatriculationProductId).HasColumnName("iMatriculationProductId");

                entity.Property(e => e.IMaxStudent).HasColumnName("iMaxStudent");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Tmessage>(entity =>
            {
                entity.HasKey(e => e.IMessageId);

                entity.ToTable("TMessage");

                entity.Property(e => e.IMessageId).HasColumnName("iMessageId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvContent).HasColumnName("nvContent");

                entity.Property(e => e.NvRecipientNumber)
                    .HasMaxLength(10)
                    .HasColumnName("nvRecipientNumber")
                    .IsFixedLength();

                entity.Property(e => e.NvSenderNumber)
                    .HasMaxLength(10)
                    .HasColumnName("nvSenderNumber")
                    .IsFixedLength();

                entity.Property(e => e.NvSubject).HasColumnName("nvSubject");
            });

            modelBuilder.Entity<Tmoderator>(entity =>
            {
                entity.HasKey(e => e.IModeratorId);

                entity.ToTable("TModerator");

                entity.Property(e => e.IModeratorId).HasColumnName("iModeratorId");

                entity.Property(e => e.BIsActive).HasColumnName("bIsActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICityType).HasColumnName("iCityType");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumberBox).HasColumnName("iNumberBox");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.NvDeliveryAddress)
                    .HasMaxLength(100)
                    .HasColumnName("nvDeliveryAddress");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(50)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(50)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(50)
                    .HasColumnName("nvMobile");

                entity.Property(e => e.NvPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvPhone");

                entity.Property(e => e.NvRegion)
                    .HasMaxLength(50)
                    .HasColumnName("nvRegion");
            });

            modelBuilder.Entity<TmoderatorInstitution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TModeratorInstitution");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreateByUserId).HasColumnName("iCreateByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IModeratoId).HasColumnName("iModeratoId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Trate>(entity =>
            {
                entity.HasKey(e => e.IRateId);

                entity.ToTable("TRate");

                entity.Property(e => e.IRateId).HasColumnName("iRateId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IMaxNumStudents).HasColumnName("iMaxNumStudents");

                entity.Property(e => e.IMinNumStudents).HasColumnName("iMinNumStudents");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.IYearId).HasColumnName("iYearId");

                entity.Property(e => e.NRate)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nRate");
            });

            modelBuilder.Entity<TreceiptPayment>(entity =>
            {
                entity.HasKey(e => e.IDocumentId);

                entity.ToTable("TReceiptPayment");

                entity.Property(e => e.IDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("iDocumentId");

                entity.Property(e => e.DAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dAmount");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtDateOfMaturity)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDateOfMaturity");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.IBankAccount).HasColumnName("iBankAccount");

                entity.Property(e => e.IBankId).HasColumnName("iBankId");

                entity.Property(e => e.IBranchNum).HasColumnName("iBranchNum");

                entity.Property(e => e.IChequeNum).HasColumnName("iChequeNum");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IPaymentMethodId).HasColumnName("iPaymentMethodId");

                entity.Property(e => e.IPaymentSubscriptionId).HasColumnName("iPaymentSubscriptionId");

                entity.Property(e => e.IReferenceNum).HasColumnName("iReferenceNum");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");
            });

            modelBuilder.Entity<Tschool>(entity =>
            {
                entity.HasKey(e => e.ISchoolId)
                    .HasName("PK_T_School");

                entity.ToTable("TSchool");

                entity.Property(e => e.ISchoolId).HasColumnName("iSchoolId");

                entity.Property(e => e.BSelfPickup).HasColumnName("bSelfPickup");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICityType).HasColumnName("iCityType");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.INumTested3Units).HasColumnName("iNumTested3Units");

                entity.Property(e => e.INumTestedAfterNoon5Units).HasColumnName("iNumTestedAfterNoon5Units");

                entity.Property(e => e.INumTestedMorning5Units).HasColumnName("iNumTestedMorning5Units");

                entity.Property(e => e.INumTestedNoon5Units).HasColumnName("iNumTestedNoon5Units");

                entity.Property(e => e.INumUnits).HasColumnName("iNumUnits");

                entity.Property(e => e.ISchoolSymbol).HasColumnName("iSchoolSymbol");

                entity.Property(e => e.ISchoolType).HasColumnName("iSchoolType");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvBiologyCoordinatorName)
                    .HasMaxLength(50)
                    .HasColumnName("nvBiologyCoordinatorName");

                entity.Property(e => e.NvComments)
                    .HasMaxLength(500)
                    .HasColumnName("nvComments");

                entity.Property(e => e.NvCoordinatorMail)
                    .HasMaxLength(50)
                    .HasColumnName("nvCoordinatorMail");

                entity.Property(e => e.NvCoordinatorPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvCoordinatorPhone");

                entity.Property(e => e.NvProvincialAdvisorName)
                    .HasMaxLength(50)
                    .HasColumnName("nvProvincialAdvisorName");

                entity.Property(e => e.NvProvincialAdvisorPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvProvincialAdvisorPhone");

                entity.Property(e => e.NvResponsibleDistributionName)
                    .HasMaxLength(50)
                    .HasColumnName("nvResponsibleDistributionName");

                entity.Property(e => e.NvResponsibleDistributionPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvResponsibleDistributionPhone");

                entity.Property(e => e.NvSchoolName)
                    .HasMaxLength(50)
                    .HasColumnName("nvSchoolName");
            });

            modelBuilder.Entity<Tsetting>(entity =>
            {
                entity.HasKey(e => e.ISettingId);

                entity.ToTable("TSetting");

                entity.Property(e => e.ISettingId).HasColumnName("iSettingId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus)
                    .HasColumnName("iSysRowStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NvSettingName)
                    .HasMaxLength(50)
                    .HasColumnName("nvSettingName");

                entity.Property(e => e.NvValue)
                    .HasMaxLength(200)
                    .HasColumnName("nvValue");
            });

            modelBuilder.Entity<Tstudent>(entity =>
            {
                entity.HasKey(e => e.IStudentId);

                entity.ToTable("TStudent");

                entity.Property(e => e.IStudentId).HasColumnName("iStudentId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IInstitutionId).HasColumnName("iInstitutionId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvEmail)
                    .HasMaxLength(50)
                    .HasColumnName("nvEmail");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvIdentity)
                    .HasMaxLength(50)
                    .HasColumnName("nvIdentity");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(50)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMessagesPhone)
                    .HasMaxLength(50)
                    .HasColumnName("nvMessagesPhone");
            });

            modelBuilder.Entity<TstudentAdvancedStudy>(entity =>
            {
                entity.HasKey(e => e.IStudentAdvancedStudyId);

                entity.ToTable("TStudentAdvancedStudy");

                entity.Property(e => e.IStudentAdvancedStudyId).HasColumnName("iStudentAdvancedStudyId");

                entity.Property(e => e.BAdvancedStudyDone).HasColumnName("bAdvancedStudyDone");

                entity.Property(e => e.BGeneratedCertificate).HasColumnName("bGeneratedCertificate");

                entity.Property(e => e.BSigned).HasColumnName("bSigned");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.DtRegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtRegistrationDate");

                entity.Property(e => e.DtRegistrationStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtRegistrationStatusDate");

                entity.Property(e => e.IAdvancedStudyInstitutionId).HasColumnName("iAdvancedStudyInstitutionId");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IDemandsPaymentYearId).HasColumnName("iDemandsPaymentYearId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IRegistrationStatus).HasColumnName("iRegistrationStatus");

                entity.Property(e => e.IStudentId).HasColumnName("iStudentId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvComment).HasColumnName("nvComment");
            });

            modelBuilder.Entity<TsysBankList>(entity =>
            {
                entity.HasKey(e => e.IBankId)
                    .HasName("PK_T_SysBankList");

                entity.ToTable("TSysBankList");

                entity.Property(e => e.IBankId).HasColumnName("iBankId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.IBankNumber).HasColumnName("iBankNumber");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvBankName)
                    .HasMaxLength(100)
                    .HasColumnName("nvBankName");

                entity.Property(e => e.NvLink)
                    .HasMaxLength(250)
                    .HasColumnName("nvLink");
            });

            modelBuilder.Entity<TsysLog>(entity =>
            {
                entity.HasKey(e => e.ILogId)
                    .HasName("PK_T_SysLog");

                entity.ToTable("TSysLog");

                entity.Property(e => e.ILogId).HasColumnName("iLogId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvException).HasColumnName("nvException");

                entity.Property(e => e.NvFunction)
                    .HasMaxLength(500)
                    .HasColumnName("nvFunction");
            });

            modelBuilder.Entity<TsysLogMail>(entity =>
            {
                entity.HasKey(e => e.ILogId);

                entity.ToTable("TSysLogMail");

                entity.Property(e => e.ILogId).HasColumnName("iLogId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvException).HasColumnName("nvException");

                entity.Property(e => e.NvFunction)
                    .HasMaxLength(500)
                    .HasColumnName("nvFunction");
            });

            modelBuilder.Entity<TsysTable>(entity =>
            {
                entity.HasKey(e => e.ISysTableId)
                    .HasName("PK_T_SysTables");

                entity.ToTable("TSysTables");

                entity.Property(e => e.ISysTableId).HasColumnName("iSysTableId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvSysTableNameEng)
                    .HasMaxLength(50)
                    .HasColumnName("nvSysTableNameEng");

                entity.Property(e => e.NvSysTableNameHeb)
                    .HasMaxLength(50)
                    .HasColumnName("nvSysTableNameHeb");
            });

            modelBuilder.Entity<TsysTableRow>(entity =>
            {
                entity.HasKey(e => e.ISysTableRowId)
                    .HasName("PK_T_SysTableRow");

                entity.ToTable("TSysTableRow");

                entity.Property(e => e.ISysTableRowId).HasColumnName("iSysTableRowId");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.ISysTableId).HasColumnName("iSysTableId");

                entity.Property(e => e.NvValue)
                    .HasMaxLength(50)
                    .HasColumnName("nvValue");

                entity.HasOne(d => d.ISysTable)
                    .WithMany(p => p.TsysTableRows)
                    .HasForeignKey(d => d.ISysTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_T_SysTableRow_T_SysTables_iSysTableId");
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.IUserId);

                entity.ToTable("TUser");

                entity.Property(e => e.IUserId).HasColumnName("iUserId");

                entity.Property(e => e.BMaterialsCollector).HasColumnName("bMaterialsCollector");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.DtLatestEntering)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLatestEntering");

                entity.Property(e => e.DtStartWork)
                    .HasColumnType("datetime")
                    .HasColumnName("dtStartWork");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.IRoleType).HasColumnName("iRoleType");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.IUserStatusType).HasColumnName("iUserStatusType");

                entity.Property(e => e.IValidUserNameStatus).HasColumnName("iValidUserNameStatus");

                entity.Property(e => e.NvCarNumber)
                    .HasMaxLength(50)
                    .HasColumnName("nvCarNumber");

                entity.Property(e => e.NvFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("nvFirstName");

                entity.Property(e => e.NvIdentityNumber)
                    .HasMaxLength(50)
                    .HasColumnName("nvIdentityNumber");

                entity.Property(e => e.NvLastName)
                    .HasMaxLength(50)
                    .HasColumnName("nvLastName");

                entity.Property(e => e.NvMail)
                    .HasMaxLength(50)
                    .HasColumnName("nvMail");

                entity.Property(e => e.NvMobile)
                    .HasMaxLength(50)
                    .HasColumnName("nvMobile");

                entity.Property(e => e.NvPassword)
                    .HasMaxLength(50)
                    .HasColumnName("nvPassword");

                entity.Property(e => e.NvUserName)
                    .HasMaxLength(50)
                    .HasColumnName("nvUserName");
            });

            modelBuilder.Entity<Tyear>(entity =>
            {
                entity.HasKey(e => e.IYearId);

                entity.ToTable("TYear");

                entity.Property(e => e.IYearId)
                    .ValueGeneratedNever()
                    .HasColumnName("iYearId");

                entity.Property(e => e.BIsbLockRateLocked).HasColumnName("bIsbLockRateLocked");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCreateDate");

                entity.Property(e => e.DtLastModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLastModifyDate");

                entity.Property(e => e.ICreatedByUserId).HasColumnName("iCreatedByUserId");

                entity.Property(e => e.IEnglishName).HasColumnName("iEnglishName");

                entity.Property(e => e.ILastModifyUserId).HasColumnName("iLastModifyUserId");

                entity.Property(e => e.ISysRowStatus).HasColumnName("iSysRowStatus");

                entity.Property(e => e.NvHebrewName)
                    .HasMaxLength(50)
                    .HasColumnName("nvHebrewName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
