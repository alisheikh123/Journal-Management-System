using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class tblJournal
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Journal Category")]
        public string Category { get; set; }


        [Required]
        [Display(Name = "Publication Title")]
        public string title { get; set; }

        [Required]
        [Display(Name = "NO of Author")]
        public int Noofauthor { get; set; }

        [Required]
        [Display(Name = "First Author Name")]
        public string author1 { get; set; }

       
        [Display(Name = "Second Author Name")]
        public string author2 { get; set; }

       
        [Display(Name = "Third Author Name")]
        public string author3 { get; set; }

        
        [Display(Name = "Fourth Author Name")]
        public string author4 { get; set; }

       
        [Display(Name = "Fifth Author Name")]
        public string author5 { get; set; }

        
        [Display(Name = "Sixth Author Name")]
        public string author6 { get; set; }

        [Required]
        [Display(Name = "Issuance No")]
        public int issueno { get; set; }

        [Required]
        [Display(Name = "JournalName")]
        public string journalName { get; set; }


        [Required]
        [Display(Name = "Volume No")]
        public string volumeno { get; set; }


        [Required]
        [Display(Name = "Starting Page")]
        public int SPage { get; set; }


        [Required]
        [Display(Name = "Ending Page")]
        public int EPage { get; set; }



        [Display(Name = "Total Pages")]
        public int totalPage { get; set; }


        [Required]
        [Display(Name = "Publisher Name")]
        public string pubName { get; set; }


        
        [Display(Name = "Impact Factor")]
        public string Impact_Factor { get; set; }


        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }


        [Required]
        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        public DateTime pubDate { get; set; }
    }
}