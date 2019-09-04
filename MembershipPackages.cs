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
    public class MembershipPackages
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int packageId { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Package_Name { get; set; }

        [Display(Name = "Duration")]
        [Required]
        public int Duration { get; set; }

        [Display(Name = "Joining Fee")]
        [Required]
        public decimal JoiningFee { get; set; }

        [Display(Name = "Monthly Fee")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal MonthlyFee { get; set; }

        [Display(Name = "Total Package Fee")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        [Display(Name = "Promotion")]
        [Required]
        public decimal Promotion { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        public decimal calcJoiningFee()
        {
            return (MonthlyFee * Promotion) / 100;
        }

        public decimal calc_TotalFEE()
        {
            return (MonthlyFee * Duration);
        }

          public virtual ICollection<Cart_Package> Cart_Package { get; set; }
    }

}

