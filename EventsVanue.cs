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
    public class EventsVanue
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EVenueID { get; set; }
        [Display(Name = "Event Vanue")]
        [Required]
        public string Venue { get; set; }
        public virtual ICollection<EventsClass> EventsClass { get; set; }
     
    }
}
