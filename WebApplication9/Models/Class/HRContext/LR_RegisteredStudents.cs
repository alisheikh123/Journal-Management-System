namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_RegisteredStudents
    {
        public int id { get; set; }

        public int Roll_No { get; set; }

        public string Department { get; set; }

        public string name { get; set; }

        public string status { get; set; }
    }
}
