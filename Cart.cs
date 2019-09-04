using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace KFP.DATA
{
   public class Cart
    {

        [Key]
        public string cart_id { get; set; }
        public DateTime date_created { get; set; }

        public virtual ICollection<Cart_Package> Cart_Packages { get; set; }
    }
}
