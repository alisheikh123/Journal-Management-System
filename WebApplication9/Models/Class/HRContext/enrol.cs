namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("enrol")]
    public partial class enrol
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column("enrol", Order = 1)]
        [StringLength(20)]
        public string enrol1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long status { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long courseid { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sortorder { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public long? enrolperiod { get; set; }

        public long? enrolstartdate { get; set; }

        public long? enrolenddate { get; set; }

        public byte? expirynotify { get; set; }

        public long? expirythreshold { get; set; }

        public byte? notifyall { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(20)]
        public string cost { get; set; }

        [StringLength(3)]
        public string currency { get; set; }

        public long? roleid { get; set; }

        public long? customint1 { get; set; }

        public long? customint2 { get; set; }

        public long? customint3 { get; set; }

        public long? customint4 { get; set; }

        public long? customint5 { get; set; }

        public long? customint6 { get; set; }

        public long? customint7 { get; set; }

        public long? customint8 { get; set; }

        [StringLength(255)]
        public string customchar1 { get; set; }

        [StringLength(255)]
        public string customchar2 { get; set; }

        [StringLength(1333)]
        public string customchar3 { get; set; }

        public decimal? customdec1 { get; set; }

        public decimal? customdec2 { get; set; }

        [StringLength(1000)]
        public string customtext1 { get; set; }

        [StringLength(1000)]
        public string customtext2 { get; set; }

        [StringLength(1000)]
        public string customtext3 { get; set; }

        [StringLength(1000)]
        public string customtext4 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timecreated { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timemodified { get; set; }
    }
}
