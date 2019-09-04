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
    public class Eq_Reports
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EqRepID { get; set; }

        [ForeignKey("Equipment")]
        [Required]
        [Display(Name = "Equipment Number")]
        public int EqID { get; set; }

        //[ForeignKey("KlassVenue")]
        //[Required]
        //[Display(Name = "Venue")]
        //public int VenueID { get; set; }

        [Required]
        [Display(Name = "Venue")]
        public string Venue { get; set; }


        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual KlassVenue KlassVenue { get; set; }




    }
}
