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
    public class EventsClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }


        [Display(Name = "Event Type")]
        [Required]
        [ForeignKey("Eventsdates")]
        public int EID { get; set; }

        [Display(Name = "Venue Size")]
        [Required]
        public int Size { get; set; }

        [ForeignKey("EventsVanue")]
        [Display(Name = "Event Venue")]
        [Required]
        public int EVenueID { get; set; }

        [Display(Name = "Day")]
        [Required]
        public string Days { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Event Start-time")]
        [Required]
        public string Time_in { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Event End-time")]
        [Required]
        public string Time_Out { get; set; }
        public virtual Eventsdates Eventsdates { get; set; }

        public virtual EventsVanue EventsVanue { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }


    }

}
