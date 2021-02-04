namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBackup_DB
    {
        [Key]
        public int backup_Id { get; set; }

        public DateTime? backup_Date { get; set; }

        public string backup_filePath { get; set; }
    }
}
