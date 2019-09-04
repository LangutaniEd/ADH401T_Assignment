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
    public class Equipment
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EqID { get; set; }

        [Required]
        [Display(Name = "Equipment Number")]
        public int Eq_NUMBER { get; set; }

        [ForeignKey("Equipment_Type")]
        [Required]
        [Display(Name = "Equipment Type")]
        public int TypeID { get; set; }

        [ForeignKey("KlassVenue")]
        [Required]
        [Display(Name = "Venue")]
        public int VenueID { get; set; }



        [Required]
        [Display(Name = "Equipment Status")]
        public string Status { get; set; }

        public virtual KlassVenue KlassVenue { get; set; }
        public virtual Equipment_Type Equipment_Type { get; set; }
      
    }
}
