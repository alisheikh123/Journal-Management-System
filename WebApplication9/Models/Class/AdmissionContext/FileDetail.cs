namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FileDetail
    {
        [Key]
        public int FileId { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string FileSize { get; set; }

        [StringLength(20)]
        public string FileExtension { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }
    }
}
