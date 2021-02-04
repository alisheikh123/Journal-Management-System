namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_TaxRatesConfiguration
    {
        public int Id { get; set; }

        public decimal LowerLimit { get; set; }

        public decimal UpperLimit { get; set; }

        public decimal FixAmountAdditions { get; set; }

        public decimal IncomeTaxRatePerc { get; set; }

        public DateTime UpdateAt { get; set; }

        public string UpdateBy { get; set; }
    }
}
