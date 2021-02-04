namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_AllowanceType
    {
        [Key]
        public int allowanceType_Id { get; set; }

        public decimal basicSalary { get; set; }

        public decimal houseAllowance { get; set; }

        public decimal ConveyanceAllowance { get; set; }

        public decimal utilitiesAllowance { get; set; }

        public decimal phoneAllowance { get; set; }

        public decimal otherAllowance { get; set; }
    }
}
