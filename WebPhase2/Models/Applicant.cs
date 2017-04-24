using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPhase2.Models
{
    public class Applicant
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string jobTiltile { get; set; }
        [Required]
        public string Skills { get; set; }


        public string Rating { get; set; }
        public string isTop5 { get; set; }
        public string isHired { get; set; }
    }
}