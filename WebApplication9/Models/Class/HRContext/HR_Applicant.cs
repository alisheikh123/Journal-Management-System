namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Applicant()
        {
            HR_Candidate = new HashSet<HR_Candidate>();
        }

        public int Id { get; set; }

        public int? VacancieId { get; set; }

        public DateTime ApplyDate { get; set; }

        public int Cv_FormId { get; set; }

        public bool isSelectedForInterview { get; set; }

        public int DeparmentId { get; set; }

        public int DesiginationId { get; set; }

        public virtual HR_Cv_Form HR_Cv_Form { get; set; }

        public virtual HR_Vacancie HR_Vacancie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Candidate> HR_Candidate { get; set; }
    }
}
