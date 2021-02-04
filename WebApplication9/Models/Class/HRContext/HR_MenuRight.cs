namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_MenuRight
    {
        [Key]
        public int menuRightsId { get; set; }

        public int subMenuId { get; set; }

        public string roleId { get; set; }
    }
}
