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
    public class PersonalTrainor
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ptID { get; set; }

        [Required]
        [Display(Name = "Number of Sessions")]
        public int Sessions { get; set; }

        [Required]
        [Display(Name = "Session Duration")]
        public string S_Duration { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Session Description")]
        public string S_Description { get; set; }

        [ForeignKey("PT_Category")]
        [Display(Name = "Training Category")]
        [Required]
        public int CatID { get; set; }

        public virtual PT_Category PT_Category { get; set; }

    }
}

