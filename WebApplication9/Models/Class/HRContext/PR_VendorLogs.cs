namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_VendorLogs
    {
        public int id { get; set; }

        [Required]
        public string company_name { get; set; }

        public DateTime log_date { get; set; }

        [Required]
        [StringLength(100)]
        public string company_desc { get; set; }

        [Required]
        public string contact_name { get; set; }

        [Required]
        public string email { get; set; }

        public string activity { get; set; }

        public int? vendor_id_id { get; set; }

        public virtual PR_VendorList PR_VendorList { get; set; }
    }
}
