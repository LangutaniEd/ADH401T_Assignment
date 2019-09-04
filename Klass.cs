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
    public class Klass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KlassId { get; set; }


        [Display(Name = "Class Type")]
        [Required]
        [ForeignKey("KlassType")]
        public int tID { get; set; }

        [Display(Name = "Class Size")]
        [Required]
        public int Size { get; set; }

        [ForeignKey("KlassVenue")]
        [Display(Name = "Class Venue")]
        [Required]
        public int VenueID { get; set; }


        [ForeignKey("Equipment_Type")]
        [Display(Name = "Equipment")]
        [Required]

        public int TypeID { get; set; }



        [Display(Name = "Day")]
        [Required]
        public string Day { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Start-time")]
        [Required]
        public string Time_in { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "End-time")]
        [Required]
        public string Time_Out { get; set; }

        //[ForeignKey("Employee")]
        //[Display(Name = "Trainor")]
        //[Required]
        //public int EmployeeId { get; set; }
        public virtual KlassVenue KlassVenue { get; set; }

        public virtual KlassType KlassType { get; set; }
        public virtual Equipment_Type Equipment_Type { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }

        //public virtual Employee Employee { get; set; }


    }

}
