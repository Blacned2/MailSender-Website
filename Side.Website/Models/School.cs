using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Side.Website.Models
{
    public class School
    {
        [Key]
        public int SchooldID { get; set; }
        public int CityID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLogoPath { get; set; }
        [ForeignKey("CityID")]
        public virtual City City { get; set; }
    }
}
