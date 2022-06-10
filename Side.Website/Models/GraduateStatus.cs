using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Side.Website.Models
{
    public class GraduateStatus
    {
        [Key]
        public int GraduateStatusID { get; set; }
        public string Status { get; set; }
    }
}
