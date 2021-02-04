namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLMSUniReg")]
    public partial class tblLMSUniReg
    {
        public int id { get; set; }

        public string universityName { get; set; }

        public string contactNo { get; set; }

        public string email { get; set; }

        public int? stateId { get; set; }

        public int? cityId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dept { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Program { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Courses { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Facuty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Student { get; set; }

        public string ContactPerson { get; set; }

        public string ContactPersonMoblie { get; set; }
    }
}
