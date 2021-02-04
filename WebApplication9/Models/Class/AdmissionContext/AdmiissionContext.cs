using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication9.Models.Class.AdmissionContext
{
    public partial class AdmiissionContext : DbContext
    {
        public AdmiissionContext()
            : base("name=AdmiissionContext")
        {
        }

        public virtual DbSet<AcdmcCalndr> AcdmcCalndrs { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminSignUp> AdminSignUps { get; set; }
        public virtual DbSet<AdmissionCounter> AdmissionCounters { get; set; }
        public virtual DbSet<AdmissionOpnCl> AdmissionOpnCls { get; set; }
        public virtual DbSet<Business_Faculty> Business_Faculty { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<coursedetail> coursedetails { get; set; }
        public virtual DbSet<cous> couses { get; set; }
        public virtual DbSet<cover> covers { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Enrolled_Students> Enrolled_Students { get; set; }
        public virtual DbSet<Enrolled_Studentsss> Enrolled_Studentsss { get; set; }
        public virtual DbSet<EventDetail> EventDetails { get; set; }
        public virtual DbSet<faculttyComment> faculttyComments { get; set; }
        public virtual DbSet<FacultySignUp> FacultySignUps { get; set; }
        public virtual DbSet<FeeSpecial> FeeSpecials { get; set; }
        public virtual DbSet<FileDetail> FileDetails { get; set; }
        public virtual DbSet<FilesTable> FilesTables { get; set; }
        public virtual DbSet<Galery> Galeries { get; set; }
        public virtual DbSet<LabsDetail> LabsDetails { get; set; }
        public virtual DbSet<maritlist> maritlists { get; set; }
        public virtual DbSet<News_EventsDetail> News_EventsDetail { get; set; }
        public virtual DbSet<NewsData> NewsDatas { get; set; }
        public virtual DbSet<NewsImage> NewsImages { get; set; }
        public virtual DbSet<NewsPanel> NewsPanels { get; set; }
        public virtual DbSet<NewsSite> NewsSites { get; set; }
        public virtual DbSet<Outline> Outlines { get; set; }
        public virtual DbSet<ProgramsChangingHistory> ProgramsChangingHistories { get; set; }
        public virtual DbSet<Prospectus> Prospectus { get; set; }
        public virtual DbSet<Psychology_Faculty> Psychology_Faculty { get; set; }
        public virtual DbSet<scholarship> scholarships { get; set; }
        public virtual DbSet<SelectedStudent> SelectedStudents { get; set; }
        public virtual DbSet<SliderData> SliderDatas { get; set; }
        public virtual DbSet<SliderImg> SliderImgs { get; set; }
        public virtual DbSet<StuPayment_History> StuPayment_History { get; set; }
        public virtual DbSet<tblAcademicInfo> tblAcademicInfoes { get; set; }
        public virtual DbSet<tblActivitySheet> tblActivitySheets { get; set; }
        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tbladmissiondocument> tbladmissiondocuments { get; set; }
        public virtual DbSet<tblAdmissionsFee> tblAdmissionsFees { get; set; }
        public virtual DbSet<tblApplyProgram> tblApplyPrograms { get; set; }
        public virtual DbSet<tblBackup_DB> tblBackup_DB { get; set; }
        public virtual DbSet<tblBasicInfo> tblBasicInfoes { get; set; }
        public virtual DbSet<tblchallantemp> tblchallantemps { get; set; }
        public virtual DbSet<tblchangedept> tblchangedepts { get; set; }
        public virtual DbSet<tblCours> tblCourses { get; set; }
        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblDetail> tblDetails { get; set; }
        public virtual DbSet<tblDiscountApplied> tblDiscountApplieds { get; set; }
        public virtual DbSet<tbldiscountLog> tbldiscountLogs { get; set; }
        public virtual DbSet<tblDiscountType> tblDiscountTypes { get; set; }
        public virtual DbSet<tblDropStudent> tblDropStudents { get; set; }
        public virtual DbSet<tblExamType> tblExamTypes { get; set; }
        public virtual DbSet<tblFac_qualification> tblFac_qualification { get; set; }
        public virtual DbSet<tblFac_Research> tblFac_Research { get; set; }
        public virtual DbSet<tblFaculty_USKT> tblFaculty_USKT { get; set; }
        public virtual DbSet<tblforumcenter> tblforumcenters { get; set; }
        public virtual DbSet<tblfreezStudent> tblfreezStudents { get; set; }
        public virtual DbSet<tblFundAgency> tblFundAgencies { get; set; }
        public virtual DbSet<tblFundAgencyType> tblFundAgencyTypes { get; set; }
        public virtual DbSet<tblHod> tblHods { get; set; }
        public virtual DbSet<tblInstallment> tblInstallments { get; set; }
        public virtual DbSet<tblMoodleUser> tblMoodleUsers { get; set; }
        public virtual DbSet<tblOricCOVID> tblOricCOVIDs { get; set; }
        public virtual DbSet<tblOricEvent> tblOricEvents { get; set; }
        public virtual DbSet<tblOricModalPopup> tblOricModalPopups { get; set; }
        public virtual DbSet<tblOricMou> tblOricMous { get; set; }
        public virtual DbSet<tblOricPublication> tblOricPublications { get; set; }
        public virtual DbSet<tblOricResearchProject> tblOricResearchProjects { get; set; }
        public virtual DbSet<tblOricResearchProjectsHead> tblOricResearchProjectsHeads { get; set; }
        public virtual DbSet<tblOricSlider> tblOricSliders { get; set; }
        public virtual DbSet<tblProgram> tblPrograms { get; set; }
        public virtual DbSet<tblprogramsdetail> tblprogramsdetails { get; set; }
        public virtual DbSet<tblStu_Fee_Record> tblStu_Fee_Record { get; set; }
        public virtual DbSet<tblSubDept> tblSubDepts { get; set; }
        public virtual DbSet<tblUniDept> tblUniDepts { get; set; }
        public virtual DbSet<tblUniEmp> tblUniEmps { get; set; }
        public virtual DbSet<tblUniSubDept> tblUniSubDepts { get; set; }
        public virtual DbSet<tblwavof> tblwavofs { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<UogFaculty> UogFaculties { get; set; }
        public virtual DbSet<UogOutline> UogOutlines { get; set; }
        public virtual DbSet<UOGStudent> UOGStudents { get; set; }
        public virtual DbSet<VCode> VCodes { get; set; }
        public virtual DbSet<Verify> Verifies { get; set; }
        public virtual DbSet<abc> abcs { get; set; }
        public virtual DbSet<checkDB> checkDBs { get; set; }
        public virtual DbSet<indexpage> indexpages { get; set; }
        public virtual DbSet<signup> signups { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<tmptbl_Enroll> tmptbl_Enroll { get; set; }

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

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.AdmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.Fall_Spring)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.DepID)
                .IsUnicode(false);

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.ProgramID)
                .IsUnicode(false);

            modelBuilder.Entity<Enrolled_Students>()
                .Property(e => e.CompleteRollno)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Heading)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.ShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.LongDesc)
                .IsUnicode(false);

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

            modelBuilder.Entity<FeeSpecial>()
                .Property(e => e.semester)
                .IsFixedLength();

            modelBuilder.Entity<FilesTable>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<FilesTable>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Galery>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Galery>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.ShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.LongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<News_EventsDetail>()
                .Property(e => e.EventDate)
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

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.Old_Prog)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramsChangingHistory>()
                .Property(e => e.New_Prog)
                .IsUnicode(false);

            modelBuilder.Entity<Prospectus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Prospectus>()
                .Property(e => e.Path)
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

            modelBuilder.Entity<SliderData>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<SliderImg>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<StuPayment_History>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<tblApplyProgram>()
                .Property(e => e.departmentID)
                .IsUnicode(false);

            modelBuilder.Entity<tblApplyProgram>()
                .Property(e => e.programID)
                .IsUnicode(false);

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

            modelBuilder.Entity<abc>()
                .Property(e => e.password)
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
                .Property(e => e.SubDepID)
                .IsUnicode(false);

            modelBuilder.Entity<tmptbl_Enroll>()
                .Property(e => e.ProgramID)
                .IsUnicode(false);
        }
    }
}
