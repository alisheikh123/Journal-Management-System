namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChangeProgramHistory")]
    public partial class tblChangeProgramHistory
    {
        [Key]
        public int dept_change_history_Id { get; set; }

        [StringLength(50)]
        public string RegID { get; set; }

        public string old_Roll_No { get; set; }

        public string new_Roll_No { get; set; }

        [StringLength(5)]
        public string old_Dep_ID { get; set; }

        [StringLength(5)]
        public string old_Program_ID { get; set; }

        [StringLength(5)]
        public string new_Dep_ID { get; set; }

        [StringLength(5)]
        public string new_Program_ID { get; set; }

        public DateTime? date_Added { get; set; }

        public int? user_Id { get; set; }
    }
}
