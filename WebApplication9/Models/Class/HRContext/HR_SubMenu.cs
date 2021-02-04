namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SubMenu
    {
        [Key]
        public int subMenuId { get; set; }

        public string subMenuName { get; set; }

        public string controller { get; set; }

        public string action { get; set; }

        public int mainMenuId { get; set; }
    }
}
