namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_MainMenu
    {
        [Key]
        public int mainMenuId { get; set; }

        public string mainMenuName { get; set; }

        public int sidebarSection { get; set; }

        public string icon { get; set; }
    }
}
