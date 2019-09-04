using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KFP.DATA
{
  public class Cart_Package
    {
        [Key]

        public string CartP_ID { get; set; }
        [ForeignKey("Cart")]
        public string cart_id { get; set; }

        [ForeignKey("MembershipPackages")]
        public int packageId { get; set; }

        public int quantity { get; set; }
        public decimal price { get; set; }

        public virtual MembershipPackages MembershipPackages { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
