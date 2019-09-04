using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KFP.DATA
{
   public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_ID { get; set; }

        public DateTime date_created { get; set; }
        [ForeignKey("Client")]

        public string Email { get; set; }
        public bool shipped { get; set; }
        public string status { get; set; }
        public bool packed { get; set; }
        public virtual ICollection<Order_Item> Order_Items { get; set; }
        public virtual ICollection<OrderAddress> OrderAddress { get; set; }
        public virtual ICollection<OrderTracking> OrderTracking { get; set; }
        public virtual Client Client { get; set; }
    }
}
