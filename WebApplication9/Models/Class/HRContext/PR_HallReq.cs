namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_HallReq
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_HallReq()
        {
            PR_HallReqItems = new HashSet<PR_HallReqItems>();
            PR_HallReqLogs = new HashSet<PR_HallReqLogs>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public string date { get; set; }

        public DateTime reser_date { get; set; }

        [Required]
        public string time_from { get; set; }

        [Required]
        public string time_to { get; set; }

        public int no_of_person { get; set; }

        public int dept_id { get; set; }

        public int hall_type { get; set; }

        [Required]
        [StringLength(100)]
        public string purpose { get; set; }

        public int emp_id { get; set; }

        public int status_id { get; set; }

        public DateTime status_change_time { get; set; }

        public int no_of_items { get; set; }

        public string activity { get; set; }

        public int reporting_person { get; set; }

        public int previous_reporting_person { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual PR_ReqStatus PR_ReqStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_HallReqItems> PR_HallReqItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_HallReqLogs> PR_HallReqLogs { get; set; }
    }
}
