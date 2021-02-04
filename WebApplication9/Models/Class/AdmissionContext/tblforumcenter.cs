namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblforumcenter")]
    public partial class tblforumcenter
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string upload_Image { get; set; }

        public string heading { get; set; }

        public string Description { get; set; }
    }
}
