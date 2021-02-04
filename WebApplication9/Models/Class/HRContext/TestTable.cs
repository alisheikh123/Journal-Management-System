namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestTable")]
    public partial class TestTable
    {
        public int Id { get; set; }

        [Required]
        public string Img { get; set; }

        [StringLength(50)]
        public string Hod { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Rank { get; set; }

        [Required]
        [StringLength(50)]
        public string Qulaification { get; set; }

        [Required]
        [StringLength(50)]
        public string Institute { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Fb { get; set; }

        [StringLength(50)]
        public string Twitter { get; set; }

        [StringLength(50)]
        public string Google { get; set; }

        [StringLength(50)]
        public string Linkdin { get; set; }
    }
}
