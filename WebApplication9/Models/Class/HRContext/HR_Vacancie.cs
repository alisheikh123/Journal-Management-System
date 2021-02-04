namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Vacancie
    {
        public int Id { get; set; }

        public int RecruitmentRequestId { get; set; }

        public DateTime OpeningDate { get; set; }

        public DateTime ClosingDate { get; set; }

        public DateTime PostingDate { get; set; }

        public virtual HR_RecruitmentRequest HR_RecruitmentRequest { get; set; }
    }
}
