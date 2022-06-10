using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Side.Website.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        //public int SchooldID { get; set; }
        public int GraduateStatusID { get; set; }
        public string Nationality { get; set; }
        public bool Gender { get; set; }
        public string SchoolName { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string Email { get; set; }
        public DateTime? GraduateYear { get; set; }
        public string CreationVideoPath { get; set; }
        public string ShowRealVideoPath { get; set; }

        //[ForeignKey("SchoolID")]
        //public virtual School School { get; set; }
        [ForeignKey("GraduateStatusID")]
        public virtual GraduateStatus GraduateStatus { get; set; }
    }
}
