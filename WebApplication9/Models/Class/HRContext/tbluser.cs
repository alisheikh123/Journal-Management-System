namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbluser")]
    public partial class tbluser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string auth { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte confirmed { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte policyagreed { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte deleted { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte suspended { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mnethostid { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string username { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string password { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(255)]
        public string idnumber { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string firstname { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string lastname { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string email { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte emailstop { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(15)]
        public string icq { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string skype { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string yahoo { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string aim { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string msn { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(20)]
        public string phone1 { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(20)]
        public string phone2 { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(255)]
        public string institution { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(255)]
        public string department { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(255)]
        public string address { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(120)]
        public string city { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(2)]
        public string country { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(30)]
        public string lang { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(30)]
        public string calendartype { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(50)]
        public string theme { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(100)]
        public string timezone { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long firstaccess { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lastaccess { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lastlogin { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long currentlogin { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(45)]
        public string lastip { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(15)]
        public string secret { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long picture { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(255)]
        public string url { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        [Key]
        [Column(Order = 38)]
        public byte descriptionformat { get; set; }

        [Key]
        [Column(Order = 39)]
        public byte mailformat { get; set; }

        [Key]
        [Column(Order = 40)]
        public byte maildigest { get; set; }

        [Key]
        [Column(Order = 41)]
        public byte maildisplay { get; set; }

        [Key]
        [Column(Order = 42)]
        public byte autosubscribe { get; set; }

        [Key]
        [Column(Order = 43)]
        public byte trackforums { get; set; }

        [Key]
        [Column(Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timecreated { get; set; }

        [Key]
        [Column(Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timemodified { get; set; }

        [Key]
        [Column(Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long trustbitmask { get; set; }

        [StringLength(255)]
        public string imagealt { get; set; }

        [StringLength(255)]
        public string lastnamephonetic { get; set; }

        [StringLength(255)]
        public string firstnamephonetic { get; set; }

        [StringLength(255)]
        public string middlename { get; set; }

        [StringLength(255)]
        public string alternatename { get; set; }
    }
}
