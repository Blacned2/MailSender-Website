using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Side.Website.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public string CityName { get; set; }
        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }
    }
}
