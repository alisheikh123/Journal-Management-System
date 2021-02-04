namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBasicInfo")]
    public partial class tblBasicInfo
    {
        public int id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string MobileNum { get; set; }

        public string LandLNum { get; set; }

        public string Gender { get; set; }

        public string MatrialSts { get; set; }

        public string DOB { get; set; }

        public string Cnic { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string StuPerHouse { get; set; }

        public string StuPerTown { get; set; }

        public string StuPerCity { get; set; }

        public string StuPerNBCity { get; set; }

        public string StuTepHouse { get; set; }

        public string StuTepTown { get; set; }

        public string StuTepCity { get; set; }

        public string StuTemNBCity { get; set; }

        public string AltEmail { get; set; }

        public string StuPName { get; set; }

        public string StuPCnic { get; set; }

        public string StuPEmail { get; set; }

        public string StuPNum { get; set; }

        public string ECNumber { get; set; }

        public string StuPHouse { get; set; }

        public string StuPTown { get; set; }

        public string StuPCity { get; set; }

        public string StuPNBCity { get; set; }

        public string StuPOcptn { get; set; }

        public string StuPOrg { get; set; }

        public string StuPDesgn { get; set; }

        public string Image { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Required]
        public string StuRegNo { get; set; }

        public string cbpg { get; set; }

        public string StuPRelation { get; set; }

        public string uname { get; set; }

        public bool? active { get; set; }

        public string code { get; set; }

        public string FatherFirstName { get; set; }

        public string EmengencyNum { get; set; }

        public string FatherLastName { get; set; }

        public string EmengencyName { get; set; }

        public string EmengencyRelation { get; set; }

        public string EmengencyEmail { get; set; }

        public string year { get; set; }

        public int? intv { get; set; }

        public string fireBaseToken { get; set; }
    }
}
