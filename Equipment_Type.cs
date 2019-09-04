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
    public class Equipment_Type
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeID { get; set; }
        [Display(Name = "Equipment_Type")]
        [Required]
        public string Eq_type { get; set; }
        public virtual ICollection<Klass> Klass { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }



    }
}
