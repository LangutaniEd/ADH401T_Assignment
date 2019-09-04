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
    public class Contract
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractID { get; set; }



    }
}
