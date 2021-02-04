namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGuestRegistration")]
    public partial class tblGuestRegistration
    {
        public int id { get; set; }

        public string studentCnic { get; set; }

        public string GFName { get; set; }

        public string GLName { get; set; }

        public string GCnic { get; set; }

        public string Picture { get; set; }

        public string fee { get; set; }

        public bool? feestatus { get; set; }
    }
}
