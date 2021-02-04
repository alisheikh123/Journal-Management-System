using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication9.Models.Class.HRContext
{
    public partial class HR_Context : DbContext
    {
        public HR_Context()
            : base("name=HR_Context")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminSignUp> AdminSignUps { get; set; }
        public virtual DbSet<AdmissionAnswerReview> AdmissionAnswerReviews { get; set; }
        public virtual DbSet<AdmissionCounter> AdmissionCounters { get; set; }
        public virtual DbSet<AdmissionOpnCl> AdmissionOpnCls { get; set; }
        public virtual DbSet<AdmissionQuestion> AdmissionQuestions { get; set; }
        public virtual DbSet<ApplyProgram> ApplyPrograms { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Business_Faculty> Business_Faculty { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<Country1> Countries1 { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<District1> Districts1 { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<faculttyComment> faculttyComments { get; set; }
        public virtual DbSet<FacultySignUp> FacultySignUps { get; set; }
        public virtual DbSet<FeeSpecial> FeeSpecials { get; set; }
        public virtual DbSet<FeeSpecial1> FeeSpecials1 { get; set; }
        public virtual DbSet<Galery> Galeries { get; set; }
        public virtual DbSet<HR_Candidate> HR_Candidate { get; set; }
        public virtual DbSet<HR_Certification> HR_Certification { get; set; }
        public virtual DbSet<HR_Country> HR_Country { get; set; }
        public virtual DbSet<HR_Cv_Form> HR_Cv_Form { get; set; }
        public virtual DbSet<HR_Deduction> HR_Deduction { get; set; }
        public virtual DbSet<HR_Designation> HR_Designation { get; set; }
        public virtual DbSet<HR_DesignationSalary> HR_DesignationSalary { get; set; }
        public virtual DbSet<HR_District> HR_District { get; set; }
        public virtual DbSet<HR_Division> HR_Division { get; set; }
        public virtual DbSet<HR_Education> HR_Education { get; set; }
        public virtual DbSet<HR_Employee> HR_Employee { get; set; }
        public virtual DbSet<HR_EmployeEducation> HR_EmployeEducation { get; set; }
        public virtual DbSet<HR_EmployeeLanguage> HR_EmployeeLanguage { get; set; }
        public virtual DbSet<HR_EmployeeSkill> HR_EmployeeSkill { get; set; }
        public virtual DbSet<HR_EmployeeTrainingHistory> HR_EmployeeTrainingHistory { get; set; }
        public virtual DbSet<HR_EmployeeType> HR_EmployeeType { get; set; }
        public virtual DbSet<HR_Employment> HR_Employment { get; set; }
        public virtual DbSet<HR_EmploymentHistory> HR_EmploymentHistory { get; set; }
        public virtual DbSet<HR_EmplyeeResearch> HR_EmplyeeResearch { get; set; }
        public virtual DbSet<HR_Exam> HR_Exam { get; set; }
        public virtual DbSet<HR_HolidaysConfiguration> HR_HolidaysConfiguration { get; set; }
        public virtual DbSet<HR_Language> HR_Language { get; set; }
        public virtual DbSet<HR_Leave> HR_Leave { get; set; }
        public virtual DbSet<HR_LeaveDayLimitEmpType> HR_LeaveDayLimitEmpType { get; set; }
        public virtual DbSet<HR_LeaveRecord> HR_LeaveRecord { get; set; }
        public virtual DbSet<HR_LeaveRequest> HR_LeaveRequest { get; set; }
        public virtual DbSet<HR_LeaveTypes> HR_LeaveTypes { get; set; }
        public virtual DbSet<HR_MainMenu> HR_MainMenu { get; set; }
        public virtual DbSet<HR_Meeting> HR_Meeting { get; set; }
        public virtual DbSet<HR_MeetingParicipent> HR_MeetingParicipent { get; set; }
        public virtual DbSet<HR_MenuRight> HR_MenuRight { get; set; }
        public virtual DbSet<HR_PayGrade> HR_PayGrade { get; set; }
        public virtual DbSet<HR_PayRollConfiguration> HR_PayRollConfiguration { get; set; }
        public virtual DbSet<HR_PayrollDetail> HR_PayrollDetail { get; set; }
        public virtual DbSet<HR_PayrollMaster> HR_PayrollMaster { get; set; }
        public virtual DbSet<HR_PayrollSetup> HR_PayrollSetup { get; set; }
        public virtual DbSet<HR_ProfileImage> HR_ProfileImage { get; set; }
        public virtual DbSet<HR_RecruitmentRequest> HR_RecruitmentRequest { get; set; }
        public virtual DbSet<HR_Skill> HR_Skill { get; set; }
        public virtual DbSet<HR_SubMenu> HR_SubMenu { get; set; }
        public virtual DbSet<HR_Tax> HR_Tax { get; set; }
        public virtual DbSet<HR_TaxRatesConfiguration> HR_TaxRatesConfiguration { get; set; }
        public virtual DbSet<HR_Vacancie> HR_Vacancie { get; set; }
        public virtual DbSet<HR_WorkingDaysForDepartmentConfiguration> HR_WorkingDaysForDepartmentConfiguration { get; set; }
        public virtual DbSet<HR_WorkTimingConfiguration> HR_WorkTimingConfiguration { get; set; }
        public virtual DbSet<IMS_Accounts> IMS_Accounts { get; set; }
        public virtual DbSet<IMS_Item> IMS_Item { get; set; }
        public virtual DbSet<IMS_ItemType> IMS_ItemType { get; set; }
        public virtual DbSet<IMS_ItemUnit> IMS_ItemUnit { get; set; }
        public virtual DbSet<IMS_MainCategory> IMS_MainCategory { get; set; }
        public virtual DbSet<IMS_PurchaseOrder> IMS_PurchaseOrder { get; set; }
        public virtual DbSet<IMS_PurchaseOrderItemDetail> IMS_PurchaseOrderItemDetail { get; set; }
        public virtual DbSet<IMS_Requisition> IMS_Requisition { get; set; }
        public virtual DbSet<IMS_RequisitionDetail> IMS_RequisitionDetail { get; set; }
        public virtual DbSet<IMS_RequisitionType> IMS_RequisitionType { get; set; }
        public virtual DbSet<IMS_SubCategory> IMS_SubCategory { get; set; }
        public virtual DbSet<IMS_VendorItemCategory> IMS_VendorItemCategory { get; set; }
        public virtual DbSet<IMS_VendorItemRate> IMS_VendorItemRate { get; set; }
        public virtual DbSet<LabsDetail> LabsDetails { get; set; }
        public virtual DbSet<maritlist> maritlists { get; set; }
        public virtual DbSet<moodleLmsData> moodleLmsDatas { get; set; }
        public virtual DbSet<News_EventsDetail> News_EventsDetail { get; set; }
        public virtual DbSet<NewsData> NewsDatas { get; set; }
        public virtual DbSet<NewsImage> NewsImages { get; set; }
        public virtual DbSet<NewsPanel> NewsPanels { get; set; }
        public virtual DbSet<NewsSite> NewsSites { get; set; }
        public virtual DbSet<Outline> Outlines { get; set; }
        public virtual DbSet<PayGrade> PayGrades { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<ProgramHead> ProgramHeads { get; set; }
        public virtual DbSet<ProgramsChangingHistory> ProgramsChangingHistories { get; set; }
        public virtual DbSet<Psychology_Faculty> Psychology_Faculty { get; set; }
        public virtual DbSet<SelectedStudent> SelectedStudents { get; set; }
        public virtual DbSet<SelectedStudentsdata> SelectedStudentsdatas { get; set; }
        public virtual DbSet<SliderData> SliderDatas { get; set; }
        public virtual DbSet<SliderImg> SliderImgs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tabRank> tabRanks { get; set; }
        public virtual DbSet<tblAcademicInfo> tblAcademicInfoes { get; set; }
        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tbladmissiondocument> tbladmissiondocuments { get; set; }
        public virtual DbSet<tblApplyProgram> tblApplyPrograms { get; set; }
        public virtual DbSet<tblBasicInfo> tblBasicInfoes { get; set; }
        public virtual DbSet<tblBatch> tblBatches { get; set; }
        public virtual DbSet<tblcampain> tblcampains { get; set; }
        public virtual DbSet<tblCampainsRegistration> tblCampainsRegistrations { get; set; }
        public virtual DbSet<tblchallantemp> tblchallantemps { get; set; }
        public virtual DbSet<tblchangedept> tblchangedepts { get; set; }
        public virtual DbSet<tblChangeProgramHistory> tblChangeProgramHistories { get; set; }
        public virtual DbSet<tblcover> tblcovers { get; set; }
        public virtual DbSet<tbldegree> tbldegrees { get; set; }
        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblDept1> tblDepts1 { get; set; }
        public virtual DbSet<tblDiscountApplied> tblDiscountApplieds { get; set; }
        public virtual DbSet<tbldiscountLog> tbldiscountLogs { get; set; }
        public virtual DbSet<tblDiscountType> tblDiscountTypes { get; set; }
        public virtual DbSet<tblDiscretAdm> tblDiscretAdms { get; set; }
        public virtual DbSet<tblDropStudent> tblDropStudents { get; set; }
        public virtual DbSet<tblExamType> tblExamTypes { get; set; }
        public virtual DbSet<tblFac_qualification> tblFac_qualification { get; set; }
        public virtual DbSet<tblFac_Research> tblFac_Research { get; set; }
        public virtual DbSet<tblFaculty_USKT> tblFaculty_USKT { get; set; }
        public virtual DbSet<tblfreezStudent> tblfreezStudents { get; set; }
        public virtual DbSet<tblGuestRegistration> tblGuestRegistrations { get; set; }
        public virtual DbSet<tblHod> tblHods { get; set; }
        public virtual DbSet<tblmajor> tblmajors { get; set; }
        public virtual DbSet<tblMeritCal> tblMeritCals { get; set; }
        public virtual DbSet<tblMoodleUser> tblMoodleUsers { get; set; }
        public virtual DbSet<tblProgram> tblPrograms { get; set; }
        public virtual DbSet<tblprogramsdetail> tblprogramsdetails { get; set; }
        public virtual DbSet<tblsocietybody> tblsocietybodies { get; set; }
        public virtual DbSet<tblsocietymember> tblsocietymembers { get; set; }
        public virtual DbSet<tblStu_Fee_Record> tblStu_Fee_Record { get; set; }
        public virtual DbSet<tblStu_Fee_Recorddata> tblStu_Fee_Recorddata { get; set; }
        public virtual DbSet<tblSubDept> tblSubDepts { get; set; }
        public virtual DbSet<tblUniDept> tblUniDepts { get; set; }
        public virtual DbSet<tblUniEmp> tblUniEmps { get; set; }
        public virtual DbSet<tblUniSubDept> tblUniSubDepts { get; set; }
        public virtual DbSet<tblUogFeeChallan> tblUogFeeChallans { get; set; }
        public virtual DbSet<tblusktsociety> tblusktsocieties { get; set; }
        public virtual DbSet<tblVisitor> tblVisitors { get; set; }
        public virtual DbSet<tblwavof> tblwavofs { get; set; }
        public virtual DbSet<Tehsil> Tehsils { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<UniBook> UniBooks { get; set; }
        public virtual DbSet<UogBook> UogBooks { get; set; }
        public virtual DbSet<UogFaculty> UogFaculties { get; set; }
        public virtual DbSet<UogOutline> UogOutlines { get; set; }
        public virtual DbSet<UOGStudent> UOGStudents { get; set; }
        public virtual DbSet<VCode> VCodes { get; set; }
        public virtual DbSet<Verify> Verifies { get; set; }
        public virtual DbSet<checkDB> checkDBs { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<enrol> enrols { get; set; }
        public virtual DbSet<indexpage> indexpages { get; set; }
        public virtual DbSet<signup> signups { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<tbluser> tblusers { get; set; }
        public virtual DbSet<tmptbl_Enroll> tmptbl_Enroll { get; set; }
        public virtual DbSet<user_enrolments> user_enrolments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmissionCounter>()
                .Property(e => e.Admission)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionCounter>()
                .Property(e => e.Counter)
                .IsFixedLength();

            modelBuilder.Entity<AdmissionOpnCl>()
                .Property(e => e.Admission)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionOpnCl>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUserRoles)
                .WithRequired(e => e.AspNetRole)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserRoles)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Hod)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Qulaification)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Institute)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Google)
                .IsUnicode(false);

            modelBuilder.Entity<Business_Faculty>()
                .Property(e => e.Linkdin)
                .IsUnicode(false);

            modelBuilder.Entity<Country1>()
                .HasMany(e => e.Divisions)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country1>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Districts)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<faculttyComment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<faculttyComment>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<faculttyComment>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<FeeSpecial>()
                .Property(e => e.FCode)
                .IsUnicode(false);

            modelBuilder.Entity<FeeSpecial>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FeeSpecial>()
                .Property(e => e.FeeType)
                .IsUnicode(false);

            modelBuilder.Entity<FeeSpecial>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Galery>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Galery>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<HR_Country>()
                .HasMany(e => e.HR_Division)
                .WithRequired(e => e.HR_Country)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Country>()
                .HasMany(e => e.HR_Employee)
                .WithOptional(e => e.HR_Country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<HR_Designation>()
                .HasMany(e => e.HR_Employee)
                .WithOptional(e => e.HR_Designation)
                .HasForeignKey(e => e.DesignationId);

            modelBuilder.Entity<HR_Designation>()
                .HasMany(e => e.HR_EmploymentHistory)
                .WithRequired(e => e.HR_Designation)
                .HasForeignKey(e => e.DesignationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Designation>()
                .HasMany(e => e.HR_RecruitmentRequest)
                .WithRequired(e => e.HR_Designation)
                .HasForeignKey(e => e.DesignationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_District>()
                .HasMany(e => e.HR_Employee)
                .WithOptional(e => e.HR_District)
                .HasForeignKey(e => e.DistrictId);

            modelBuilder.Entity<HR_Division>()
                .HasMany(e => e.HR_Employee)
                .WithOptional(e => e.HR_Division)
                .HasForeignKey(e => e.DivisionId);

            modelBuilder.Entity<HR_Education>()
                .HasMany(e => e.HR_EmployeEducation)
                .WithRequired(e => e.HR_Education)
                .HasForeignKey(e => e.EducationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Education>()
                .HasMany(e => e.HR_Exam)
                .WithRequired(e => e.HR_Education)
                .HasForeignKey(e => e.EducationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_Deduction)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_DesignationSalary)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmployeEducation)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmployeeLanguage)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmployeeSkill)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmployeeTrainingHistory)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmploymentHistory)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_EmplyeeResearch)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_LeaveRecord)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_LeaveRequest)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employee>()
                .HasMany(e => e.HR_PayrollDetail)
                .WithRequired(e => e.HR_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_EmployeeType>()
                .HasMany(e => e.HR_LeaveDayLimitEmpType)
                .WithRequired(e => e.HR_EmployeeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Employment>()
                .HasMany(e => e.HR_RecruitmentRequest)
                .WithRequired(e => e.HR_Employment)
                .HasForeignKey(e => e.EmploymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Language>()
                .HasMany(e => e.HR_EmployeeLanguage)
                .WithRequired(e => e.HR_Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_LeaveTypes>()
                .HasMany(e => e.HR_LeaveDayLimitEmpType)
                .WithRequired(e => e.HR_LeaveTypes)
                .HasForeignKey(e => e.leaveType_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_LeaveTypes>()
                .HasMany(e => e.HR_LeaveRequest)
                .WithRequired(e => e.HR_LeaveTypes)
                .HasForeignKey(e => e.LeaveTypesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Meeting>()
                .HasMany(e => e.HR_MeetingParicipent)
                .WithRequired(e => e.HR_Meeting)
                .HasForeignKey(e => e.MeetingId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_PayGrade>()
                .HasMany(e => e.HR_Designation)
                .WithRequired(e => e.HR_PayGrade)
                .HasForeignKey(e => e.PayGradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_RecruitmentRequest>()
                .HasMany(e => e.HR_Vacancie)
                .WithRequired(e => e.HR_RecruitmentRequest)
                .HasForeignKey(e => e.RecruitmentRequestId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HR_Skill>()
                .HasMany(e => e.HR_EmployeeSkill)
                .WithRequired(e => e.HR_Skill)
                .HasForeignKey(e => e.SkillId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMS_Accounts>()
                .HasMany(e => e.IMS_PurchaseOrder)
                .WithRequired(e => e.IMS_Accounts)
                .HasForeignKey(e => e.accountId);

            modelBuilder.Entity<IMS_Accounts>()
                .HasMany(e => e.IMS_VendorItemCategory)
                .WithRequired(e => e.IMS_Accounts)
                .HasForeignKey(e => e.accountId);

            modelBuilder.Entity<IMS_Accounts>()
                .HasMany(e => e.IMS_VendorItemRate)
                .WithRequired(e => e.IMS_Accounts)
                .HasForeignKey(e => e.accountId);

            modelBuilder.Entity<IMS_Item>()
                .HasMany(e => e.IMS_PurchaseOrderItemDetail)
                .WithRequired(e => e.IMS_Item)
                .HasForeignKey(e => e.itemId);

            modelBuilder.Entity<IMS_Item>()
                .HasMany(e => e.IMS_RequisitionDetail)
                .WithRequired(e => e.IMS_Item)
                .HasForeignKey(e => e.itemId);

            modelBuilder.Entity<IMS_Item>()
                .HasMany(e => e.IMS_VendorItemRate)
                .WithRequired(e => e.IMS_Item)
                .HasForeignKey(e => e.itemId);

            modelBuilder.Entity<IMS_PurchaseOrder>()
                .HasMany(e => e.IMS_PurchaseOrderItemDetail)
                .WithRequired(e => e.IMS_PurchaseOrder)
                .HasForeignKey(e => e.orderId);

            modelBuilder.Entity<IMS_Requisition>()
                .HasMany(e => e.IMS_RequisitionDetail)
                .WithRequired(e => e.IMS_Requisition)
                .HasForeignKey(e => e.requistionId);

            modelBuilder.Entity<IMS_RequisitionType>()
                .HasMany(e => e.IMS_Requisition)
                .WithRequired(e => e.IMS_RequisitionType)
                .HasForeignKey(e => e.requisitionTypeId);

            modelBuilder.Entity<IMS_SubCategory>()
                .HasMany(e => e.IMS_VendorItemCategory)
                .WithRequired(e => e.IMS_SubCategory)
                .HasForeignKey(e => e.subCategoryId);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.ShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.LongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<NewsData>()
                .Property(e => e.NewsMarque)
                .IsUnicode(false);

            modelBuilder.Entity<NewsData>()
                .Property(e => e.NewsHeadLines)
                .IsUnicode(false);

            modelBuilder.Entity<NewsData>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<NewsImage>()
                .Property(e => e.Imgs)
                .IsUnicode(false);

            modelBuilder.Entity<NewsPanel>()
                .Property(e => e.NewsMarque)
                .IsUnicode(false);

            modelBuilder.Entity<NewsPanel>()
                .Property(e => e.NewsHeadLines)
                .IsUnicode(false);

            modelBuilder.Entity<NewsPanel>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<NewsSite>()
                .Property(e => e.NewsMarque)
                .IsUnicode(false);

            modelBuilder.Entity<NewsSite>()
                .Property(e => e.NewsHeadLines)
                .IsUnicode(false);

            modelBuilder.Entity<PayGrade>()
                .HasMany(e => e.Designations)
                .WithRequired(e => e.PayGrade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.Old_Prog)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.New_Prog)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Hod)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Qulaification)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Institute)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Google)
                .IsUnicode(false);

            modelBuilder.Entity<Psychology_Faculty>()
                .Property(e => e.Linkdin)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudent>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudent>()
                .Property(e => e.DepID)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudent>()
                .Property(e => e.ProgramID)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudentsdata>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudentsdata>()
                .Property(e => e.DepID)
                .IsUnicode(false);

            modelBuilder.Entity<SelectedStudentsdata>()
                .Property(e => e.ProgramID)
                .IsUnicode(false);

            modelBuilder.Entity<SliderData>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<SliderImg>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<tblApplyProgram>()
                .Property(e => e.departmentID)
                .IsUnicode(false);

            modelBuilder.Entity<tblApplyProgram>()
                .Property(e => e.programID)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.old_Roll_No)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.new_Roll_No)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.old_Dep_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.old_Program_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.new_Dep_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblChangeProgramHistory>()
                .Property(e => e.new_Program_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblDept1>()
                .HasMany(e => e.tblPrograms)
                .WithOptional(e => e.tblDept)
                .HasForeignKey(e => e.grandparent_id);

            modelBuilder.Entity<tblDept1>()
                .HasMany(e => e.tblSubDepts)
                .WithOptional(e => e.tblDept)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tblDiscountType>()
                .HasMany(e => e.tblDiscountApplieds)
                .WithOptional(e => e.tblDiscountType)
                .HasForeignKey(e => e.discounttypeid);

            modelBuilder.Entity<tblDiscountType>()
                .HasMany(e => e.tblDiscountApplieds1)
                .WithOptional(e => e.tblDiscountType1)
                .HasForeignKey(e => e.discounttypeid);

            modelBuilder.Entity<tblExamType>()
                .HasMany(e => e.tblAcademicInfoes)
                .WithRequired(e => e.tblExamType)
                .HasForeignKey(e => new { e.ExamLevel, e.ExamType })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblFac_qualification>()
                .Property(e => e.qualification_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblFac_qualification>()
                .Property(e => e.institute)
                .IsUnicode(false);

            modelBuilder.Entity<tblFac_Research>()
                .Property(e => e.Publications_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblFac_Research>()
                .Property(e => e.Publications_Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblFac_Research>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<tblFac_Research>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.rank)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.Past_Experience)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.depertment_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.dept_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.faculty_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.fb)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.twitter)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.google)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.linkdin)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaculty_USKT>()
                .Property(e => e.OtherRank)
                .IsUnicode(false);

            modelBuilder.Entity<tblMeritCal>()
                .Property(e => e.FinalMarks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tblSubDept>()
                .HasMany(e => e.tblPrograms)
                .WithOptional(e => e.tblSubDept)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Hod)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Qulaification)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Institute)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Google)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Linkdin)
                .IsUnicode(false);

            modelBuilder.Entity<UniBook>()
                .Property(e => e.Book_Name)
                .IsUnicode(false);

            modelBuilder.Entity<UniBook>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<UniBook>()
                .Property(e => e.Dept_semester)
                .IsUnicode(false);

            modelBuilder.Entity<UniBook>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<UogBook>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Hod)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Qulaification)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Institute)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Deapertment)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Google)
                .IsUnicode(false);

            modelBuilder.Entity<UogFaculty>()
                .Property(e => e.Linkdin)
                .IsUnicode(false);

            modelBuilder.Entity<UogOutline>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<checkDB>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<checkDB>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<checkDB>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.idnumber)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.format)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.calendartype)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.theme)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.enrol1)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.cost)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customchar1)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customchar2)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customchar3)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customdec1)
                .HasPrecision(12, 7);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customdec2)
                .HasPrecision(12, 7);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customtext1)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customtext2)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customtext3)
                .IsUnicode(false);

            modelBuilder.Entity<enrol>()
                .Property(e => e.customtext4)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.auth)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.idnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.icq)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.skype)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.yahoo)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.aim)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.msn)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.institution)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.calendartype)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.theme)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.timezone)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.lastip)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.secret)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.imagealt)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.lastnamephonetic)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.firstnamephonetic)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<tbluser>()
                .Property(e => e.alternatename)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.aYear)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.FallSprg)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.DepID)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.ProgramID)
                .IsUnicode(false);
        }
    }
}
