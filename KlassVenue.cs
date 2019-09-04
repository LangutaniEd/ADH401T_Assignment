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
    public class KlassVenue
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueID { get; set; }
        [Display(Name = "Class Venue")]
        [Required]
        public string Venue { get; set; }
        public virtual ICollection<Klass> Klass { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
