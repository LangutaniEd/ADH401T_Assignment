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
    public class PT_Category
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatID { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string CatName { get; set; }

        [Required]
        [Display(Name = "description")]
        public string Cat_Descr { get; set; }

        public ICollection<PersonalTrainor> PersonalTrainor { get; set; }
    }
}
