namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdmissionAnswerReview
    {
        public int Id { get; set; }

        public int AnswerReview { get; set; }

        public int AdmissionQuestionId { get; set; }

        public string AnswerText { get; set; }

        public long s_id { get; set; }

        public virtual AdmissionQuestion AdmissionQuestion { get; set; }
    }
}
