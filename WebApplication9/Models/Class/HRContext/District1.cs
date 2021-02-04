namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Districts")]
    public partial class District1
    {
        public int Id { get; set; }

        public string DistrictName { get; set; }

        public int? Province_id { get; set; }
    }
}
