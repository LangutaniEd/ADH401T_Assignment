using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFP.DATA
{
  public  class OrderAddress
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int address_id { get; set; }

        [ForeignKey("Order")]
        public int Order_ID { get; set; }
        
        [Display(Name = "Bank Name")]
        public string street { get; set; }
        [Display(Name = "Account Type")]

        public string city { get; set; }
        [Display(Name = "Account Number")]

        public string zipcode { get; set; }
        public virtual Order Order { get; set; }
    }
}
