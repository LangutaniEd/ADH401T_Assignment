using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KFP.DATA
{
    public class Eventsdates
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }

        [Required]
        [Display(Name = "Event Type")]
        public string Etype { get; set; }

        [Required]
        [Display(Name = "Event description")]
        public string description { get; set; }

        [Required]
        [Display(Name = " Events Attendance")]
        public string Attendance { get; set; }
    }
}