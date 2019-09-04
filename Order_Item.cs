using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KFP.DATA
{
   public class Order_Item
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Item_id { get; set; }
        [ForeignKey("Order")]
        public int Order_id { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("MembershipPackages")]
        public int packageId { get; set; }

        public virtual MembershipPackages MembershipPackages { get; set; }

        public int quantity { get; set; }
        public decimal price { get; set; }

        public bool replied { get; set; }
        public Nullable<DateTime> date_replied { get; set; }

        public bool accepted { get; set; }
        public Nullable<DateTime> date_accepted { get; set; }

        //public bool shipped { get; set; }
        public string status { get; set; }
        //public Nullable<DateTime> date_shipped { get; set; }
    }
}
