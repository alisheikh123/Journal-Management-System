namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_VehicleReq
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_VehicleReq()
        {
            PR_VehicleReqLogs = new HashSet<PR_VehicleReqLogs>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public string submit_date { get; set; }

        public DateTime depart_date { get; set; }

        public DateTime arrival_date { get; set; }

        [Required]
        public string depart_time { get; set; }

        [Required]
        public string arrival_time { get; set; }

        public int no_of_person { get; set; }

        public int emp_id { get; set; }

        public int dept_id { get; set; }

        public int reporting_person { get; set; }

        public int previous_reporting_person { get; set; }

        public int status_id { get; set; }

        public DateTime status_change_time { get; set; }

        public int stay_days { get; set; }

        [Required]
        [StringLength(100)]
        public string destination { get; set; }

        [StringLength(70)]
        public string doc_lug_desc { get; set; }

        [Required]
        [StringLength(100)]
        public string purpose { get; set; }

        public string tour_type { get; set; }

        public string activity { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual PR_ReqStatus PR_ReqStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_VehicleReqLogs> PR_VehicleReqLogs { get; set; }
    }
}
