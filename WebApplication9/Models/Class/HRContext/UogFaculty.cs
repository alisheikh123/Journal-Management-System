namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UogFaculty")]
    public partial class UogFaculty
    {
        public int Id { get; set; }

        public string Img { get; set; }

        [StringLength(50)]
        public string Hod { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Rank { get; set; }

        [StringLength(50)]
        public string Qulaification { get; set; }

        [StringLength(50)]
        public string Institute { get; set; }

        [StringLength(50)]
        public string Deapertment { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Fb { get; set; }

        [Required]
        [StringLength(50)]
        public string Twitter { get; set; }

        [Required]
        [StringLength(50)]
        public string Google { get; set; }

        [Required]
        [StringLength(50)]
        public string Linkdin { get; set; }

        [StringLength(50)]
        public string Department_Code { get; set; }
    }
}
