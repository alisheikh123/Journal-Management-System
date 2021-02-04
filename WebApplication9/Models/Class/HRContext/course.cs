namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("course")]
    public partial class course
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long category { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sortorder { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(254)]
        public string fullname { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string shortname { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string idnumber { get; set; }

        [StringLength(1000)]
        public string summary { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte summaryformat { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(21)]
        public string format { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte showgrades { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int newsitems { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long startdate { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long enddate { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long marker { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long maxbytes { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short legacyfiles { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short showreports { get; set; }

        [Key]
        [Column(Order = 16)]
        public byte visible { get; set; }

        [Key]
        [Column(Order = 17)]
        public byte visibleold { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short groupmode { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short groupmodeforce { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long defaultgroupingid { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(30)]
        public string lang { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(30)]
        public string calendartype { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(50)]
        public string theme { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timecreated { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timemodified { get; set; }

        [Key]
        [Column(Order = 26)]
        public byte requested { get; set; }

        [Key]
        [Column(Order = 27)]
        public byte enablecompletion { get; set; }

        [Key]
        [Column(Order = 28)]
        public byte completionnotify { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cacherev { get; set; }
    }
}
