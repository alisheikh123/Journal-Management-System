namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblcampain
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string startdate { get; set; }

        public string enddate { get; set; }

        public string Department { get; set; }

        public string image { get; set; }

        public string reason { get; set; }
    }
}
