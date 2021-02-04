namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCampainsRegistration")]
    public partial class tblCampainsRegistration
    {
        public int id { get; set; }

        public int? compain_id { get; set; }

        public string firstName { get; set; }

        public string rollNo { get; set; }

        public string mobileNo { get; set; }

        public string cnic { get; set; }

        public string email { get; set; }

        public string lastName { get; set; }

        public string batch { get; set; }

        public int? department_id { get; set; }

        public int? program_id { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string Employed { get; set; }

        public string OrganizationName { get; set; }

        public string OrganizationDepartment { get; set; }

        public string OrganizationDesignation { get; set; }

        public string EmployedSince { get; set; }

        public string TotalYearExperince { get; set; }

        public string JobRelatedToQualification { get; set; }

        public string NoOfStaff { get; set; }

        public string Picture { get; set; }

        public bool? feestatus { get; set; }

        public int? fee { get; set; }

        public string bankdate { get; set; }

        public string regNo { get; set; }
    }
}
