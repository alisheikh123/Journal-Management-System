namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Meeting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Meeting()
        {
            HR_MeetingParicipent = new HashSet<HR_MeetingParicipent>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string DocPath { get; set; }

        [Required]
        public string Venue { get; set; }

        public DateTime HeldOn { get; set; }

        public string UpdateByUserId { get; set; }

        public DateTime? UpdateAt { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int meetingStatus { get; set; }

        public string MinutesPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_MeetingParicipent> HR_MeetingParicipent { get; set; }
    }
}
