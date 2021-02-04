namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_AssignRolestoUsers
    {
        public int id { get; set; }

        public int user { get; set; }

        public int usercategory_id { get; set; }

        public int priority { get; set; }

        public DateTime? date { get; set; }

        public string Activity { get; set; }

        public virtual LR_UserCategory LR_UserCategory { get; set; }
    }
}
