using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication9.Models.Class
{
    public class JournalModel
    {

        public int id { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public int Noofauthor { get; set; }
        public string author1 { get; set; }
        public string author2 { get; set; }
        public string author3 { get; set; }
        public string author4 { get; set; }
        public string author5 { get; set; }
        public string author6 { get; set; }
        public string JournalNm { get; set; }
        public int issueno { get; set; }
        public string volumeno { get; set; }
        public int SPage { get; set; }
        public int EPage { get; set; }
        public int TPage { get; set; }
        public string pubName { get; set; }
        public string impactFactor { get; set; }
        public string Country { get; set; }
        [DataType(DataType.Date)]
        public DateTime PubDate { get; set; }
    }
}