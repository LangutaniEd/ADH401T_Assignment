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
    public class KlassType
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tID { get; set; }

        [Required]
        [Display(Name = "Class Type")]
        public string Ktype { get; set; }

        [Required]
        [Display(Name = "description")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Attendance")]
        public string Attendance { get; set; }
    }
}