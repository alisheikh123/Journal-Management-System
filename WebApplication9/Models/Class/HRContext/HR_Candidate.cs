namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Candidate
    {
        public int Id { get; set; }

        public decimal? NegotiatedSalary { get; set; }

        public string Remarks { get; set; }

        public bool? isAprovedByBOG { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public string ApprovedBy { get; set; }

        public int ApplicantId { get; set; }

        public bool? IsRecommended { get; set; }

        public DateTime? InterviewDate { get; set; }
    }
}
