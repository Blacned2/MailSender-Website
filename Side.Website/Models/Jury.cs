using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Side.Website.Models
{
    public class Jury
    {
        [Key]
        public int JuryID { get; set; }
        public string JuryName { get; set; }
        public string JurySurname { get; set; }
        public string JuryPhoto { get; set; } 
    }
}
